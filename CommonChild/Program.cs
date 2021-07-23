using System;
using System.Collections.Generic;

namespace CommonChild
{
    class Program
    {
		static int commonChild(String s1, String s2)
		{
			return LCSM4(s1.ToCharArray(), s2.ToCharArray(), s1.Length, s2.Length);

		}

		public static int LCSM4(char[] X, char[] Y, int m, int n)
		{
			int []memo = new int[n + 1];

			for (int i = 1; i <= m; i++)
			{
				int prev = 0;
				for (int j = 1; j <= n; j++)
				{
					int temp = memo[j];
					if (X[i - 1] == Y[j - 1])
					{
						memo[j] = prev + 1;
					}
					else
					{
						memo[j] = Math.Max(memo[j], memo[j - 1]);
					}
					prev = temp;
				}

			}
			return memo[n];
		}
		static void Main(string[] args)
        {
            Console.WriteLine(commonChild("LARRY","HARRY"));
        }
    }
}
