using System;
using System.Collections.Generic;

namespace SimpleArraySum
{
    class Program
    {
        public static int simpleArraySum(List<int> ar)
        {
            int sum = 0;
            for(int i = 0; i < ar.Count - 1; i++)
            {
                sum += ar[i];
            }
            return sum;

        }
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            
        }
    }
}
