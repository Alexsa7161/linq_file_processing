using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.IO;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms.VisualStyles;

namespace WinFormsApp1
{

    public class NOWithLINQ : IStrategy
    {
        public string LongestWord(string path)
        {
            string maxStr = "";
            string[] file_list = Directory.GetFiles(path);
            foreach (string file in file_list)
            {
                string strLine = "";
                using (StreamReader stream = new StreamReader(file))
                {
                    strLine = stream.ReadLine();
                    while (strLine != null)
                    {
                        string[] masStr = strLine.Split(' ');
                        foreach (string e in masStr)
                        {
                            if (e.Length > maxStr.Length)
                            { 
                                maxStr = e;
                            }
                        }
                        strLine = stream.ReadLine();
                    }
                }
            }
            return maxStr;
        }
        public Dictionary<string, int> Frequently_words(string path,int N)
        {
            Dictionary<string, int> result = new Dictionary<string, int>();
            string[] file_list = Directory.GetFiles(path);
            foreach (string file in file_list)
            {
                using (StreamReader stream = new StreamReader(file))
                {
                    string strLine = stream.ReadLine();
                    while (strLine != null)
                    {
                        string[] masStr = strLine.Split(" ");
                        foreach (string e in masStr)
                        {
                            string s = e;
                            for (int i = 0; i < s.Length-1; i++)
                            {
                                if (result.ContainsKey(s.Substring(i, 2)))
                                {
                                    result[s.Substring(i, 2)] += 1;
                                }
                                else
                                {
                                    result.Add(s.Substring(i, 2), 1);
                                }
                            }
                        }
                        strLine = stream.ReadLine();
                    }
                }
            }
            Dictionary<string,int> res = new Dictionary<string, int>();
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
            string[] file_list = Directory.GetFiles(path);
            List<string>[] mas_str = new List<string>[file_list.Length];
            for (int i = 0; i < file_list.Length; i++)
            {
                mas_str[i] = new List<string>();
                using (StreamReader stream = new StreamReader(file_list[i]))
                {
                    string strLine = stream.ReadLine();
                    while (strLine != null)
                    {
                        string[] masStr = strLine.Split(" ");
                        foreach (string e in masStr)
                        {
                            if (e == "")
                                continue;
                            if (!mas_str[i].Contains(e))
                            {
                                mas_str[i].Add(e);
                            }
                        }
                        strLine = stream.ReadLine();
                    }
                }
            }
            int[,] mas_num = new int[file_list.Length, file_list.Length];
            for (int i = 0; i < file_list.Length; i++)
            {
                int count = 0;
                for (int j = 0; j < file_list.Length; j++)
                {
                    if (i != j)
                    {
                        for (int k = 0; k < mas_str[i].Count; k++)
                        {
                            if (mas_str[j].Contains(mas_str[i][k]))
                                count++;
                        }
                    }
                    mas_num[i, j] = count;
                }
            }
            int max_num = 0;
            int first = -1;
            int second = -1;
            for (int i = 0; i < file_list.Length; i++)
            {
                for (int j = 0; j < file_list.Length; j++)
                {
                    if (mas_num[i, j] > max_num && i != j)
                    {
                        max_num = mas_num[i, j];
                        first = i;
                        second = j;
                    }
                }
            }
            return (file_list[first], file_list[second]);
        }
        public Dictionary<string,int> Frequently_Short_words(string path,int L)
        {
            Dictionary<string, int> result = new Dictionary<string, int>();
            string[] file_list = Directory.GetFiles(path);
            foreach (string file in file_list)
            {
                using (StreamReader stream = new StreamReader(file))
                {
                    string strLine = stream.ReadLine();
                    while (strLine != null)
                    {
                        string[] masStr = strLine.Split(' ');
                        foreach (string e in masStr)
                        {
                            if (e == "")
                                continue;
                            if (e.Length < L && !result.ContainsKey(e))
                            {
                                result.Add(e,1);
                            }
                            else if (result.ContainsKey(e))
                            {
                                result[e] += 1;
                            }
                        }
                        strLine = stream.ReadLine();
                    }
                }
            }
            return result;
        }
    }
}
