using System;
using System.Collections.Generic;
using System.Linq;

namespace TwoStrings
{
    class Program
    {
        static string twoStrings(string s1, string s2)
        {
            List<char> list = s1.ToCharArray().ToList();
            list = list.Distinct().ToList();

            foreach (char c in list)
            {
                if (s2.ToList().Remove(c)) return "YES";
            }
            return "NO";
        }

        static void Main(string[] args)
        {
            twoStrings("a", "cat");
        }
    }
}
