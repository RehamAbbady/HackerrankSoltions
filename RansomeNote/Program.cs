using System;
using System.Collections;
using System.Collections.Generic;

namespace RansomeNote
{
    class Program
    {
        public static void checkMagazine(List<string> magazine, List<string> note)
        {

            magazine.Sort();
            note.Sort();

            bool flag = false;
            //List<string> magList = mags.ToList();

            foreach (string ransom_w in note)
            {
                //remove same word, if it doesn't exist, return false
                if (!magazine.Remove(ransom_w))
                { Console.WriteLine("No");
                    return;
                }
                }

            Console.WriteLine("Yes");

            
        }
        static void Main(string[] args)
        {
            List<string> magazine = new List<string>();
            magazine.Add("give");
            magazine.Add("me");
            magazine.Add("one");
            magazine.Add("grand");
            magazine.Add("today");
            magazine.Add("night");

            List<string> note = new List<string>();
            note.Add("give");
            note.Add("me");
            note.Add("grand");
            note.Add("today");
            checkMagazine(magazine, note);
        }
    }
}
