using System;
using System.Collections.Generic;

namespace MarkToys
{
    class Program
    {
        public static int maximumToys(List<int> prices, int k)
        {
            prices.Sort();
            int maxToys = 0;
            if (k == 0 || prices.Count == 0)
                return maxToys;
            for (int i = 0; i < prices.Count-1; i++) {
                k -= prices[i];
                if (k < 0)
                    return maxToys;
                maxToys++;
            }
            return maxToys;
        }
        static void Main(string[] args)
        {
            List<int> prices = new List<int>();
            prices.Add(1);
            prices.Add(12);
            prices.Add(5);
            prices.Add(111);
            prices.Add(200);
            prices.Add(1000);
            prices.Add(10);
            maximumToys(prices, 50);

        }
    }
}
