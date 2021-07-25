using System;

namespace TimeConversion
{
    class Program
    {
        public static string timeConversion(string s)
        {
            string pmOram = s.Substring(s.Length - 2, 2);
            string hour = s.Substring(0, 2);
            string restOfstring = s.Substring(2, s.Length - 4);
            int hourInt = 0;
            if (pmOram == "PM")
            {
                if (hour == "12")
                    hour = "12";
                else
                {
                    hourInt = int.Parse(hour);
                    hourInt += 12;
                    hour = hourInt.ToString();
                }
            }
            else {
                if (hour == "12")
                    hour = "00";
            }
            return hour+restOfstring;

        }
        static void Main(string[] args)
        {
            Console.WriteLine(timeConversion("12:45:54PM"));
        }
    }
}
