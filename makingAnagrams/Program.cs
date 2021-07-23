using System;
using System.Collections.Generic;

namespace makingAnagrams
{
    class Program
    {
        public static int makeAnagram(string a, string b)
        {
            int[] a_freq = new int[26];
            int[] b_freq = new int[26];
            int minDeletions = 0;
            for (int i = 0; i < a.Length; i++)
            {
                char currentChar = a[i];
                int charToInt = (int)currentChar;
                int position = charToInt - (int)'a';
                a_freq[position]++;
            }
            for (int i = 0; i < b.Length; i++)
            {
                char currentChar = b[i];
                int charToInt = (int)currentChar;
                int position = charToInt - (int)'a';
                b_freq[position]++;
            }

            for (int i = 0; i < 26; i++)
            {
                int dif = Math.Abs(a_freq[i] - b_freq[i]);
                minDeletions += dif;

            }

            return minDeletions;

        }
        static void Main(string[] args)
        {
            Console.WriteLine(makeAnagram("abc", "abh"));
        }
    }
}
