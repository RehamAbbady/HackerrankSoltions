using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace FraudulentActivityNotifications
{
    class Program
    {
        static int activityNotifications(int[] expenditure, int d)
        {

            int notificationCount = 0;

            int[] sortedArray = new int[201];
            for (int i = 0; i < d; i++)
            {
                //put one in the index of the number of expenditure
                sortedArray[expenditure[i]]++;
            }

            for (int i = d; i < expenditure.Length; i++)
            {

                double median = getMedian(d, sortedArray);

                if (expenditure[i] >= 2 * median)
                {
                    notificationCount++;

                }
                //add thenext number to the sorted array
                sortedArray[expenditure[i]]++;
                //remove the first number from the sorted array
                sortedArray[expenditure[i - d]]--;

            }

            return notificationCount;

        }

        private static double getMedian(int d, int[] sortedArray)
        {
            double median = 0;
            if (d % 2 == 0)
            {
                int m1 = 0;
                int m2 = 0;
                int count = 0;
                for (int j = 0; j < sortedArray.Length; j++)
                {
                    count += sortedArray[j];
                    if (m1 == 0 && count >= d / 2)
                    {
                        m1 = j;
                    }
                    if (m2 == 0 && count >= d / 2 + 1)
                    {
                        m2 = j;
                        break;
                    }
                }
                median = (m1 + m2) / 2.0;
            }
            else
            {
                int count = 0;
                for (int j = 0; j < sortedArray.Length; j++)
                {
                    count += sortedArray[j];
                    if (count > d / 2)
                    {
                        median = j;
                        break;
                    }
                }
            }
            return median;
        }
        
        static void Main(string[] args)
        {
            List<int> mylist = new List<int>();
            mylist.Add(10);
            mylist.Add(20);
            mylist.Add(30);
            mylist.Add(40);
            mylist.Add(50);
            mylist.Add(60);

            //mylist.Add(2);
            //mylist.Add(3);
            //mylist.Add(4);
            //mylist.Add(2);
            //mylist.Add(3);
            //mylist.Add(6);
            //mylist.Add(8);
            //mylist.Add(4);
            //mylist.Add(5);
            //mylist.Add(1);
            //mylist.Add(2);
            //mylist.Add(3);
            //mylist.Add(4);
            //mylist.Add(4);
            //2 3 4 2 3 6 8 4 5
            //10 20 30 40 50
            //1 2 3 4 4

            Console.WriteLine(activityNotifications(mylist.ToArray(),4));

        }
    }
}
