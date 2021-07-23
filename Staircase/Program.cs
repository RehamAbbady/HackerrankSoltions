using System;

namespace Staircase
{
    class Program
    {
        public static void staircase(int n)
        {

            string spaces = new String(' ', n-1);
            string hashes = new String('#', 1);
            int i = 0;
            while (i<n) {
                Console.WriteLine(spaces + hashes);
                i++;
                if(spaces.Length!=0)
                    spaces=spaces.Remove(0,1);
                hashes=hashes + "#";

            }

        }
        static void Main(string[] args)
        {
            staircase(6);
        }
    }
}
