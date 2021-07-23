using System;

namespace CountingValleys
{
    class Program
    {
        public static int countingValleys(int steps, string path)
        {
            int elevation = 0;
            int count = 0;
            int[] arr = new int[steps];
            for (int i = 0; i < path.Length; i++) {
                if (path[i] == 'D')
                { 
                    elevation--;
                    
                }               
                else
                { 
                    if (elevation == -1)
                        count++;
                    elevation++;

                }

            }
            return Math.Abs(count);
        }
        static void Main(string[] args)
        {
            Console.WriteLine(countingValleys(8, "UDDDUDUU"));
        }
    }
}
