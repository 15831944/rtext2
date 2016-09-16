using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Runtime.InteropServices;

namespace rtext
{
    public partial class Form1 : Form
    {
        [DllImport("shlwapi.dll", CharSet = CharSet.Unicode)]
        public static extern int StrCmpLogicalW(string psz1, string psz2);

        public MyData myData;

        public Form1()
        {
            InitializeComponent();

            myData = MyData.LoadMyData("rtext.bin");

            foreach (var item in myData.finds) {
                findWhatDataGridView.Rows.Add(item);
            }
            foreach (var item in myData.replaces) {
                replaceWithDataGridView.Rows.Add(item);
            }
            foreach (var item in myData.history) {
                historyDataGridView.Rows.Add(item.Dt, item.findReplace.Find, item.findReplace.Replace);
            }
            splitContainer.SplitterDistance = myData.SplitterDistance;
        }

        void AnyPropertyChanged()
        {
            replaceButton.Enabled =
                myData.findReplace.Find.Length > 0 &&
                myData.findReplace.Replace.Length > 0 &&
                myData.findReplace.Find != myData.findReplace.Replace;
        }

        void Form1KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((int)e.KeyChar == 27) {
                Close();
            }
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            myData.SplitterDistance = splitContainer.SplitterDistance;
            myData.Save();
        }

        private int futureIndex(List<string> list, string item)
        {
            int i, cnt = list.Count;
            for (i = 0; i < cnt; i++) {
                var c = StrCmpLogicalW(list[i], item);
                if (c == 0) {
                    return -1;
                } else if (c > 0) {
                    return i;
                }
            }
            return i;
        }

        private void insertFind()
        {
            var item = myData.findReplace.Find;
            var index = futureIndex(myData.finds, item);
            if (index != -1) {
                myData.finds.Insert(index, item);
                findWhatDataGridView.Rows.Insert(index, item);
                findWhatDataGridView.Rows[index].Selected = true;
            }
        }

        private void insertReplace()
        {
            var item = myData.findReplace.Find;
            var index = futureIndex(myData.finds, item);
            if (index != -1) {
                myData.finds.Insert(index, item);
                findWhatDataGridView.Rows.Insert(index, item);
                findWhatDataGridView.Rows[index].Selected = true;
            }
        }

        private void insertHistory()
        {
            var history = myData.history.FirstOrDefault(o => o.findReplace.Equals(myData.findReplace));
            if (history != null) {
                history.Dt = DateTime.Now;
                var index = myData.history.IndexOf(history);
                if (index != 0) {
                    myData.history.RemoveAt(index);
                    myData.history.Insert(0, history);
                    historyDataGridView.Rows.RemoveAt(index);
                    historyDataGridView.Rows.Insert(0, history.Dt, history.findReplace.Find, history.findReplace.Replace);
                } else {
                    historyDataGridView.Rows[0].Cells[0].Value = history.Dt;
                }
            } else {
                history = new History {
                    findReplace = new FindReplace {
                        Find = myData.findReplace.Find,
                        Replace = myData.findReplace.Replace
                    },
                    Dt = DateTime.Now
                };
                myData.history.Insert(0, history);
                historyDataGridView.Rows.Insert(0, history.Dt, history.findReplace.Find, history.findReplace.Replace);
            }
            historyDataGridView.Rows[0].Selected = true;
        }

        private void replaceButton_Click(object sender, EventArgs e)
        {
            insertFind();
            insertReplace();
            insertHistory();

            this.DialogResult = DialogResult.OK;
        }

        private void findWhatTextBox_TextChanged(object sender, EventArgs e)
        {
            myData.findReplace.Find = findWhatTextBox.Text;
            AnyPropertyChanged();
        }

        private void replaceWithTextBox_TextChanged(object sender, EventArgs e)
        {
            myData.findReplace.Replace = replaceWithTextBox.Text;
            AnyPropertyChanged();
        }

        private void findWhatDataGridView_SelectionChanged(object sender, EventArgs e)
        {
            if (findWhatDataGridView.SelectedRows.Count == 1) {
                var index = findWhatDataGridView.SelectedRows[0].Index;
                findWhatTextBox.Text = myData.finds[index];
                
                historyDataGridView.ClearSelection();
            }
        }

        private void replaceWithDataGridView_SelectionChanged(object sender, EventArgs e)
        {
            if (replaceWithDataGridView.SelectedRows.Count == 1) {
                var index = replaceWithDataGridView.SelectedRows[0].Index;
                replaceWithTextBox.Text = myData.replaces[index];
                
                historyDataGridView.ClearSelection();
            }
        }

        private void historyDataGridView_SelectionChanged(object sender, EventArgs e)
        {
            if (historyDataGridView.SelectedRows.Count == 1) {
                var index = historyDataGridView.SelectedRows[0].Index;
                findWhatTextBox.Text = myData.history[index].findReplace.Find;
                replaceWithTextBox.Text = myData.history[index].findReplace.Replace;

                findWhatDataGridView.ClearSelection();
                replaceWithDataGridView.ClearSelection();
            }
        }

        private void findWhatDataGridView_UserDeletingRow(object sender, DataGridViewRowCancelEventArgs e)
        {
            myData.finds.RemoveAt(e.Row.Index);
        }

        private void replaceWithDataGridView_UserDeletingRow(object sender, DataGridViewRowCancelEventArgs e)
        {
            myData.replaces.RemoveAt(e.Row.Index);
        }

        private void historyDataGridView_UserDeletingRow(object sender, DataGridViewRowCancelEventArgs e)
        {
            myData.history.RemoveAt(e.Row.Index);
        }

        private void splitContainer_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            splitContainer.SplitterDistance = splitContainer.Height / 2;
        }
    }
}
