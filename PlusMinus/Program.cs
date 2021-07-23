using System;
using System.Collections.Generic;

namespace PlusMinus
{
    class Program
    {
        public static void plusMinus(List<int> arr)
        {
            int minusSum = 0;
            int plusSum = 0;
            int zeroSum = 0;
            int length = arr.Count;
            for (int i = 0; i < length; i++) {
                if (arr[i] < 0)
                    minusSum++;
                else if (arr[i] > 0)
                    plusSum++;
                else zeroSum++;
                

            }
            Console.WriteLine((float)plusSum / (float)length);
            Console.WriteLine((float)minusSum / (float)length);
            Console.WriteLine((float)zeroSum / (float)length);

        }
        static void Main(string[] args)
        {
        }
    }
}
