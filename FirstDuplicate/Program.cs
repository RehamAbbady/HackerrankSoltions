using System;
using System.Collections.Generic;

namespace FirstDuplicate
{
    class Program
    {
        public static int FirstDuplicate(int[] array) {
            HashSet<int> hash = new HashSet<int>();
            for (int i = 0; i < array.Length; i++) {
                if (hash.Contains(array[i]))
                    return array[i];
                else
                    hash.Add(array[i]);
            }
            return -1;
        }
        static void Main(string[] args)
        {
            int[] array = new int[] { 1, 5, 2, 1, 4 };
            Console.WriteLine(FirstDuplicate(array));
        }
    }
}
