using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

class Program


{
    static int SherlockAndAnagrams(string s)
    {
        var subFreqs = new Dictionary<string, int>();
        var count = 0;

        for (var i = 0; i < s.Length; i++)
        {
            for (var j = i; j < s.Length; j++)
            {
                var sub = new string(s.Substring(i, j - i + 1).ToCharArray().OrderBy(p => p).ToArray());

                if (!subFreqs.ContainsKey(sub))
                {
                    subFreqs.Add(sub, 1);
                }
                else
                {
                    count += subFreqs[sub];
                    subFreqs[sub]++;
                }
            }
        }

        return count;
    }
    static void Main(String[] args)
    {
        Console.WriteLine(SherlockAndAnagrams("abba"));
    }
}