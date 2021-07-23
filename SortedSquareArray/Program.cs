using System;

namespace SortedSquareArray
{
    class Program
    {
        static int[] sortedSquaredArray(int [] array)
        {
            int[] result = new int[array.Length];
            int left = 0;
            int right = array.Length - 1;
            for (int i = array.Length - 1; i >= 0; i--) {

                if (Math.Abs(array[left]) > Math.Abs(array[right]))
                {
                    result[i] = array[left] * array[left];
                    left++;
                }
                else {
                    result[i] = array[right] * array[right];
                    right--;
                }
            }
            return result;
        }
        static void Main(string[] args)
        {
            int[] result = new int[] { -5,-4,2,3};
            Console.WriteLine(sortedSquaredArray(result));
        }
    }
}
