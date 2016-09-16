using System;
using System.IO;
using System.Linq;
using System.Text;
using System.Collections.Generic;
using System.Runtime.Serialization.Formatters.Binary;

namespace rtext
{
    [Serializable()]
    public class FindReplace : IEquatable<FindReplace>
    {
        public string Find;
        public string Replace;

        public FindReplace()
        {
            Find = string.Empty;
            Replace = string.Empty;
        }

        public bool Equals(FindReplace other)
        {
            return Find == other.Find && Replace == other.Replace;
        }
    }

    [Serializable()]
    public class History
    {
        public DateTime Dt;
        public FindReplace findReplace;
    }

    [Serializable()]
    public class MyData
    {
        public List<string> finds;
        public List<string> replaces;
        public List<History> history;

        public FindReplace findReplace;

        public int SplitterDistance;

        [field: NonSerialized()]
        public static string dataFileName;

        protected MyData()
        {
            finds = new List<string>();
            replaces = new List<string>();
            history = new List<History>();
            findReplace = new FindReplace();
            SplitterDistance = 170;
        }

        public static MyData LoadMyData(string filename)
        {
            dataFileName = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, filename);
            if (File.Exists(dataFileName)) {
                var formatter = new BinaryFormatter();
                using (Stream stream = File.OpenRead(dataFileName)) {
                    try {
                        return (MyData)formatter.Deserialize(stream);
                    } catch {}
                }
            }

            return new MyData();
        }

        public void Save()
        {
            var formatter = new BinaryFormatter();
            Stream stream = File.Create(dataFileName);
            formatter.Serialize(stream, this);
            stream.Close();
        }
    }
}
