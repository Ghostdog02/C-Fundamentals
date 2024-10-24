using System;
using System.Collections.Generic;

namespace WorkDays
{
    public class Program
    {
        public static List<DateTime> publicHolidays = new List<DateTime>
        {
            new DateTime(2023, 1, 1), // 1st Jan
            new DateTime(2023, 3, 3), // 3rd Mar
            new DateTime(2023, 4, 16),
            new DateTime(2023, 5, 1),
            new DateTime(2023, 5, 6),
            new DateTime(2023, 5, 24),
            new DateTime(2023, 9, 6),
            new DateTime(2023, 9, 22),
            new DateTime(2023, 12, 24),
            new DateTime(2023, 12, 25),
            new DateTime(2023, 12, 26),
            new DateTime(2023, 12, 27),

        };

        static void Main(string[] args)
        {
            DateTime date = DateTime.Parse(Console.ReadLine());
            Console.WriteLine(CalculateWorkDays(date));
        }

        static int CalculateWorkDays(DateTime date)
        {
            int count = 0;
            for (DateTime i = DateTime.Today; i <= date; i = i.AddDays(1))
            {
                if (IsWorkDay(i) && !IsPublicHoliday(i))
                {
                    count++;
                }
            }
            return count;
        }

        static bool IsWorkDay(DateTime date)
        {
            var day = date.DayOfWeek;
            return day != DayOfWeek.Sunday && day != DayOfWeek.Saturday;
        }

        static bool IsPublicHoliday(DateTime date)
        {
            if (publicHolidays.Contains(date))
            {
                return true;
            }
            return false;
        }
    }
}
