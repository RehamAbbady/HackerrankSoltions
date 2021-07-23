using System;
using System.Collections.Generic;

namespace FirstNonRepeatingChar
{
    class Program
    {
        static char FirstNonRepeatingChar(string s)
        {
            Dictionary<char, int> dict = new Dictionary<char, int>();
            for (int i = 0; i < s.Length - 1; i++) { 
              
                dict.Add(s[i], 1);
            }
            return ' ';
        }

        static void Main(string[] args)
        {
            Console.WriteLine(FirstNonRepeatingChar("abvacvsbd"));
        }
    }
}
