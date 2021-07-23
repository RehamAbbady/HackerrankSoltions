using System;
using System.Collections.Generic;

namespace BubbleSort
{
    class Program
    {
       
        public static void countSwaps(List<int> a)
        {
            int temp = 0;
            int swaps = 0;
            for (int write = 0; write < a.Count; write++)
            {
                for (int sort = 0; sort < a.Count - 1; sort++)
                {
                    if (a[sort] > a[sort + 1])
                    {
                        temp = a[sort + 1];
                        a[sort + 1] = a[sort];
                        a[sort] = temp;
                        swaps++;
                    }
                }
            }
            Console.WriteLine("Array is sorted in {0} swaps.", swaps);
            Console.WriteLine("First Element: {0}", a[0]);
            Console.WriteLine("Last Element: {0}", a[a.Count-1]);

        }
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }
    }
}
