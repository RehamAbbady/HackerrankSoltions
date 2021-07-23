using System;
using System.Collections.Generic;
using System.Linq;

namespace MiniMaxSum
{
    class Program
    {
        public static void miniMaxSum(List<int> arr)
        {
            long sum = 0;
            long temp = 0;
            List<long> sumList = new List<long>();

            for (int i = 0; i < arr.Count; i++) {
                sum += arr[i];
            }
            for (int i = 0; i < arr.Count; i++)
            {
                temp = sum;
                sum = sum-(long)arr[i];
                sumList.Add(sum);
                sum = temp;

            }
            Console.WriteLine(sumList.Min()+" "+sumList.Max());
            Console.WriteLine(sumList.Max());


        }
        static void Main(string[] args)
        {
            int[] arr = new int[] { 1, 2, 3, 4, 5 };
            List<int> list = arr.ToList();
            miniMaxSum(list);
        }
    }
}
