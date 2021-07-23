using System;
using System.Collections.Generic;
using System.Linq;

namespace DiagonalDifference
{
    class Program
    {
        public static int diagonalDifference(List<List<int>> arr)
        {
            int ltr = 0;
            int rtl = 0;
            int i = 0;
            int j = 0;
            
            int rows = arr.Count;
            int cols = arr[0].Count;
            int k = 0;
            int l = cols-1;
            while (i <= rows- 1&& k <= rows - 1) {
                ltr += arr[i][j];
                i++;j++;
                rtl += arr[k][l];
                k++; l--;
            }

            int result = Math.Abs(ltr - rtl);
            return result;
        }
        static void Main(string[] args)
        {
            List<List<int>> arr = new List<List<int>>();
            //List<int> arr2 = new List<int>();
            //arr2.Add
            int[,] array = new int[3, 3]{
                                {11,2,4},
                                {4,5,6},
                                {10,8,-12}
                            };
            arr = Enumerable.Range(0, array.GetLength(0))
                .Select(row => Enumerable.Range(0, array.GetLength(1))
                .Select(col => array[row, col]).ToList()).ToList();
            Console.WriteLine(diagonalDifference(arr));
        }
    }
}
