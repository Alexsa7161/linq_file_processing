using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinFormsApp1
{
    public interface IStrategy
    {
        string LongestWord(string path);
        Dictionary<string, int> Frequently_words(string path,int N);
        (string, string) SpecificFile(string path);
        Dictionary<string, int> Frequently_Short_words(string path, int L);
    }
}
