using System;

namespace SpecialStringAgain
{
    class Program
    {
        static int specialStringAgain(string s)
        {
            var result = 0;
            var i = 0;

            // 1st case, all letters are the same
            while (i < s.Length)
            {
                var charCount = 1;//while to consicutive chars are the same
                while (i + 1 < s.Length && s[i] == s[i + 1])
                {
                    i++;
                    charCount++;
                }

                result += (int)((charCount * (charCount + 1)) / 2);
                i++;
            }

            // 2nd case, palindrome
            for (i = 1; i < s.Length; i++)
            {
                var charCount = 1;
                while (
         i + charCount < s.Length &&
         i - charCount >= 0 &&
         s[i - 1] != s[i] &&
         s[i - 1] == s[i - charCount] &&
         s[i - 1] == s[i + charCount]
     )
                {
                    charCount++;
                }

                result += charCount - 1;
            }


            return result;
        }
        static void Main(string[] args)
        {
            Console.WriteLine(specialStringAgain("asaasd"));
        }
    }
}
