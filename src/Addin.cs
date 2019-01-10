using System;
using System.IO;

using Forms = System.Windows.Forms;
using System.Collections.Specialized;
using System.Text.RegularExpressions;
using System.Drawing;

using DB = Autodesk.AutoCAD.DatabaseServices;
using Autodesk.AutoCAD.Geometry;
using Autodesk.AutoCAD.Runtime;
using Autodesk.AutoCAD.PlottingServices;
using Autodesk.AutoCAD.ApplicationServices;

namespace rtext
{
    public class Addin : Autodesk.AutoCAD.Runtime.IExtensionApplication
    {
        public void Terminate()
        {
        }
        public void Initialize()
        {
        }

        [CommandMethod("rt2")]
        public void rt2()
        {
            var acDoc = Application.DocumentManager.MdiActiveDocument;
            if (acDoc != null) {
                var form = new Form1();
                if (form.ShowDialog() == Forms.DialogResult.OK) {
                    var find = form.myData.findReplace.Find;
                    var replace = form.myData.findReplace.Replace;

                    var ed = acDoc.Editor;
                    ed.WriteMessage("\nнайти: " + find + "\nзаменить: " + replace);

                    var findReplacer = new FindReplacer(find, replace);

                    rtext(findReplacer);
                }
            }
        }

        [CommandMethod("rt")]
        public void rt()
        {
            var acDoc = Application.DocumentManager.MdiActiveDocument;
            if (acDoc != null) {
                var ed = acDoc.Editor;

                var a1 = ed.GetString("\nнайти:");
                if (a1.Status != Autodesk.AutoCAD.EditorInput.PromptStatus.OK) {
                  return;
                }
                if (a1.StringResult.Length == 0) {
                  return;
                }
                
                var a2 = ed.GetString("\nзаменить:");
                if (a2.Status != Autodesk.AutoCAD.EditorInput.PromptStatus.OK) {
                  return;
                }

                var find = a1.StringResult.Replace("\"\"", "\"");
                var replace = a2.StringResult.Replace("\"\"", "\"");

                var findReplacer = new FindReplacer(find, replace);

                rtext(findReplacer);
            }
        }

        private void rtext(FindReplacer findReplacer)
        {
            var acDoc = Application.DocumentManager.MdiActiveDocument;
            if (acDoc != null) {
                using (DocumentLock dlock = acDoc.LockDocument()) {

                    var acCurDb = acDoc.Database;
                    using (var tr = acCurDb.TransactionManager.StartTransaction()) {
                        int replaced = 0;

                        var bt = (DB.BlockTable)tr.GetObject(acCurDb.BlockTableId, DB.OpenMode.ForRead, false);
                        foreach (DB.ObjectId objId in bt) {
                            DB.BlockTableRecord btr = (DB.BlockTableRecord)tr.GetObject(objId, DB.OpenMode.ForRead, false);
                            if (btr != null) {
                                if (btr.IsLayout) {
                                    foreach (DB.ObjectId objId2 in btr) {
                                        replaced += processObjectId(tr, objId2, findReplacer);
                                    }
                                }
                            }
                        }

                        acDoc.Editor.WriteMessage("\nзаменено: " + replaced + "\n");
                        if (replaced == 0) {
                            tr.Abort();
                        } else {
                            tr.Commit();
                        }
                    }

                }
            }

            var cnt = findReplacer.Found.Count;
            if (cnt > 0) {
                var msg = string.Join("\n", findReplacer.Found.ToArray());
                Forms.MessageBox.Show(msg, "Почти найдено - " + cnt.ToString(),
                    Forms.MessageBoxButtons.OK, Forms.MessageBoxIcon.Information);
            }
        }

        public int processObjectId(DB.Transaction tr, DB.ObjectId objId, FindReplacer findReplacer)
        {
            int replaced = 0;
            var ent = tr.GetObject(objId, DB.OpenMode.ForWrite, false);
            
            if (ent is DB.Table) {
                var tbl = ent as DB.Table;
                if (tbl.NumRows > 0 && tbl.NumColumns > 0) {
                    for(var r=0; r<tbl.NumRows; r++) {
                        for(var c=0; c<tbl.NumColumns; c++) {
                            var text = tbl.GetTextString(r, c, 0, DB.FormatOption.FormatOptionNone);
                            var textWithoutFormat = tbl.GetTextString(r, c, 0, DB.FormatOption.IgnoreMtextFormat);
                            if (findReplacer.ContainsIn(text, textWithoutFormat)) {
                                tbl.SetTextString(r, c, text.Replace(findReplacer.Find, findReplacer.Replace));
                                replaced++;
                            }
                        }
                    }
                }
            } else if (ent is DB.MText) {
                var mtext = ent as DB.MText;
                var text = mtext.Contents;
                var textWithoutFormat = mtext.Text;
                if (findReplacer.ContainsIn(text, textWithoutFormat)) {
                    mtext.Contents = text.Replace(findReplacer.Find, findReplacer.Replace);
                    replaced++;
                }
            } else if (ent is DB.DBText) {
                var dbtext = ent as DB.DBText;
                var text = dbtext.TextString;
                if (findReplacer.ContainsIn(text, text)) {
                    dbtext.TextString = text.Replace(findReplacer.Find, findReplacer.Replace);
                    replaced++;
                }
            } else if (ent is DB.BlockReference) {
                var br = ent as DB.BlockReference;
                var brId = br.IsDynamicBlock ? br.DynamicBlockTableRecord : br.BlockTableRecord;
                var btr = (DB.BlockTableRecord)tr.GetObject(brId, DB.OpenMode.ForRead, false);
                foreach(DB.ObjectId objId2 in btr) {
                    processObjectId(tr, objId2, findReplacer);
                }
            }
            
            return replaced;
        }
    }
}
