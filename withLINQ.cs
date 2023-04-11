using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinFormsApp1
{
    public class WithLINQ : IStrategy
    {
        public string LongestWord(string path)
        {
            string maxStr = "";
            string[] file_list = Directory.GetFiles(path);
            var words = file_list.SelectMany(path => File.ReadLines(path).SelectMany(line => line.Split(" "))).ToList();
            foreach ( var word in words ) {if (word.ToString().Length>maxStr.Length) maxStr = word.ToString(); }
            return maxStr;
        }
        public Dictionary<string, int> Frequently_words(string path, int N)
        {
            string[] file_list = Directory.GetFiles(path);
            List<string> mas_par = new List<string>();
            var words = file_list.SelectMany(path => File.ReadLines(path).SelectMany(line => line.Split(" "))).ToList();
            foreach (var e in words)
            {
                if (e == "")
                    continue;
                mas_par.AddRange(Enumerable.Range(0, e.Length-1)
                        .Select(i => e.Substring(i, 2)).ToList());
            }
            Dictionary<string, int> result = mas_par.Where(word => word != "").GroupBy(word => word).OrderBy(pair => -pair.Count()).ToDictionary(group => group.Key, group => group.Count());
            Dictionary<string, int> res = new Dictionary<string, int>();
            int max_frecuency = 0;
            for (int i = 0; i < N; i++)
            {
                try
                {
                    string s = result.FirstOrDefault(x => x.Value == result.Max(x => x.Value)).Key;
                    int t = result.FirstOrDefault(x => x.Value == result.Max(x => x.Value)).Value;
                    result.Remove(result.FirstOrDefault(x => x.Value == result.Max(x => x.Value)).Key);
                    res.Add(s, t);
                }
                catch (ArgumentNullException)
                {
                    continue;
                }
            }
            return res;
        }
        public (string, string) SpecificFile(string path)
        {
            int count = 0;
            string s = "1";
            string[] file_list = Directory.GetFiles(path);
            int n1 = 0;
            int n2 = 0;
            for (int i = 0; i < file_list.Length; i++) 
            {
                var words1 = s.SelectMany(path => File.ReadLines(file_list[i]).SelectMany(line => line.Split(" "))).ToList();
                for (int j = 0; j< file_list.Length;j++)
                {
                    if (i == j)
                        continue;
                    var words2 = s.SelectMany(path => File.ReadLines(file_list[j]).SelectMany(line => line.Split(" "))).ToList();
                    var res = words1.Intersect(words2).Count();
                    if (Convert.ToInt32(res) > count)
                    {
                        count = Convert.ToInt32(res);
                        n1 = i;
                        n2 = j;
                    }
                }
            }
            return (file_list[n1], file_list[n2]);
        }
        public Dictionary<string, int> Frequently_Short_words(string path, int L)
        {
            string[] file_list = Directory.GetFiles(path);
            return file_list.SelectMany(path => File.ReadLines(path).SelectMany(line => line.Split(" "))).Where(word => word.Length <= L && word != "").GroupBy(word => word)
.OrderBy(pair => -pair.Count()).ToDictionary(group => group.Key,group => group.Count());
        }
    }
}
