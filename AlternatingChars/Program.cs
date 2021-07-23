using System;

namespace AlternatingChars
{
    class Program
    {
        public static int alternatingCharacters(string s)
        {
            int deletions = 0;
            for (int i = 0; i < s.Length - 1; i++) {
                if (s[i] == s[i + 1])
                    deletions++;
            }
            return deletions;
        }
        static void Main(string[] args)
        {
            Console.WriteLine(alternatingCharacters("bbbb"));
        }
    }
}
