using System;
using System.Collections.Generic;

namespace TwoStrings
{
    class Program
    {
        public static string twoStrings(string s1, string s2)
        {
            HashSet<char> firstString = new HashSet<char>();
            HashSet<char> secondString = new HashSet<char>();

            for (int i = 0; i < s1.Length; i++)
            {
                firstString.Add(s1[i]);
            }
            for (int i = 0; i < s2.Length; i++)
            {
                secondString.Add(s2[i]);
            }
            firstString.IntersectWith(secondString);

            if (firstString.Count == 0)
                return "NO";
            else
                return "YES";

        }

        

        static void Main(string[] args)
        {
            //twoStrings("aardvark", "apple");
            Console.WriteLine(twoStrings("aardvark", "apple"));
        }
    }
}
