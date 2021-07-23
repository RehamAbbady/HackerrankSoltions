using System;
using System.Linq;

namespace minimumSwaps2
{
    class Program
    {
        static int minimumSwaps(int[] arr)
        {
            int minIndex = 0;
            int min = arr[0];
            int swaps = 0;
            //find minimum value and its index
            for (int i = 1; i < arr.Length; i++)
            {
                if (arr[i] < min)
                {
                    minIndex = i;
                    min = arr[i];
                }
            }
            //if the minimum value is not in the first index, swap it
            if (minIndex != 0) {
                int temp = arr[0];
                arr[0] = arr[minIndex];
                arr[minIndex] = temp;
                swaps++;
            }
            //
            for (int cur = 1; cur < arr.Length - 1; cur++) {
                //find the diffrenece between each element and the first element 
                int pos = arr[cur] - arr[0];
                while (arr[pos] != arr[cur]) {

                    int temp = arr[pos];
                    arr[pos] = arr[cur];
                    arr[cur] = temp;
                    swaps++;
                    pos = arr[cur] - arr[0];
                }
                cur = pos;
            }
            return swaps;
        }

        static void Main(string[] args)
        {
            int[] lala = new int[] {4, 3, 1, 2};
            Console.WriteLine(minimumSwaps(lala));
        }
    }
}
