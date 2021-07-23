using System;
using System.Collections.Generic;

namespace GameOfThrones
{
    class Program
    {
        public static string gameOfThrones(string s)
        {
            int count = 0;
            Dictionary<char, int> freq = new Dictionary<char, int>();
            for (int i = 0; i < s.Length; i++) {
                if (freq.ContainsKey(s[i]))
                    freq[s[i]] = freq[s[i]] + 1;
                else
                    freq.Add(s[i], 1);

            }
            //check if elements are even or odd
            foreach(var f in freq)
            {
                count += f.Value%2;
            }
            if (count> 1)
                return("NO");
            else
                return("YES");

        }
        static void Main(string[] args)
        {
            Console.WriteLine(gameOfThrones("cdefghmnopqrstuvw"));
        }
    }
}
