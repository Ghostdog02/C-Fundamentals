using System;

namespace LeapYear
{
    public class LeapYear
    {
        public static bool IsLeapYear(int year)
        {
            //if (DateTime.IsLeapYear(Year))
            //{
            //    Console.WriteLine($"{Year} is leap year.");
            //}
            //else
            //{
            //    Console.WriteLine($"{Year} isn't leap year.");
            //}
            return year % 4 == 0 && year % 100 != 0 || year % 400 == 0;
        }
    }
    
    static class Program
    {
        static void Main()
        {
            int year = int.Parse(Console.ReadLine());

            if (LeapYear.IsLeapYear(year))
            {
                Console.WriteLine($"{year} is leap year.");
            }
            else
            {
                Console.WriteLine($"{year} isn't leap year.");
            }

            for (int i = 1; i <= 9999; i++)
            {
                bool ourLeap = LeapYear.IsLeapYear(i);
                bool dateTimeLeap = DateTime.IsLeapYear(i);

                if (ourLeap != dateTimeLeap)
                {
                    throw new Exception($"Year {i} is leap according DateTime");
                }

                if (i % 100 == 0)
                    Console.WriteLine(i);
            }
        }
    }
}
