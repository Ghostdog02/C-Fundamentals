using System;

namespace IsLeapYear
{
    public class Program
    {
        static void Main()
        {
            int year = 1999;
            Console.WriteLine(IsLeap(year));
        }

        static bool IsLeap(int year)
        {
            return (year % 4 == 0) || (year % 100 == 0 && year % 400 == 0);

        }
    }
}
