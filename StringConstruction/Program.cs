using System;
using System.Collections.Generic;

namespace StringConstruction
{
    class Program
    {
        public static int stringConstruction(string s)
        {
            HashSet<char> uniqueChars = new HashSet<char>();
            foreach (char c in s) {
                uniqueChars.Add(c);
            }
            return uniqueChars.Count;
        }
        static void Main(string[] args)
        {
            Console.WriteLine(stringConstruction("aabb"));
        }
    }
}
