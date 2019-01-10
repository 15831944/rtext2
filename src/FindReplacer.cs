using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace rtext
{
    public class FindReplacer
    {
        public string Find;
        public string AlmostFind;
        public string Replace;
        public List<string> Found;

        public FindReplacer(string find, string replace)
        {
            Find = find;
            Replace = replace;
            AlmostFind = RemoveSeparator(find).ToUpper();
            Found = new List<string>();
        }

        public bool ContainsIn(string text, string textWithoutFormat)
        {
            if (text.Contains(Find)) {
                return true;
            }
            if (AlmostFind.Length > 2) {
                var parts = textWithoutFormat.Split('\n');
                foreach(var part in parts) {
                    var almost = RemoveSeparator(part).ToUpper();
                    if (almost.Contains(AlmostFind)) {
                        Found.Add(part.Trim());
                    }
                }
            }
            return false;
        }

        public string RemoveSeparator(string s)
        {
            var sb = new StringBuilder(s.Length);
            foreach (var c in s) {
                if (char.IsLetterOrDigit(c)) {
                    sb.Append(c);
                }
            }
            return sb.ToString();
        }
    }
}
