using System;
using System.Collections.Generic;
using System.Linq;

namespace TallestCandle
{
    class Program
    {
        public static int birthdayCakeCandles(List<int> candles)
        {
            int tallest = candles.Max();
            int count = 0;
            for (int i = 0; i < candles.Count; i++) {
                if (candles[i] == tallest)
                    count++;
            }
            return count;
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }
    }
}
