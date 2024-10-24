using System;
using System.Collections.Generic;

namespace CalculatingWorkDays
{
    class Program
    {
        public static List<DateTime> publicHolidays = new List<DateTime>
        {
            new DateTime(1900, 1, 1), // 1st Jan
            new DateTime(1900, 3, 3), // 3rd Mar
            new DateTime(1900, 4, 24),
            new DateTime(1900, 5, 1),
            new DateTime(1900, 5, 6),
            new DateTime(1900, 5, 24),
            new DateTime(1900, 8, 6),
            new DateTime(1900, 8, 22),
            new DateTime(1900, 12, 24),
            new DateTime(1900, 12, 25),
            new DateTime(1900, 12, 26),
            new DateTime(1900, 12, 27),
            new DateTime(1900, 12, 28),
        };

        static void PrintWorkDays(DateTime endDate)
        {
            int workingDaysCount = 0;
            var today = DateTime.Now.Date;
            for (var currentDate = today; currentDate <= endDate; currentDate = currentDate.AddDays(1))
            {
                if (IsWorkday(currentDate.DayOfWeek) && IsNotPublicHoliday(currentDate))
                {
                    workingDaysCount++;
                }
            }
            Console.WriteLine(workingDaysCount);
        }

        private static bool IsWorkday(DayOfWeek dayOfWeek)
        {
            return dayOfWeek != DayOfWeek.Saturday && dayOfWeek != DayOfWeek.Sunday;
        }

        private static bool IsNotPublicHoliday(DateTime dateTime)
        {
            foreach (var date in publicHolidays)
            {
                if (date.Month == dateTime.Month && date.Day == dateTime.Day)
                {
                    return false;
                }
            }
            return true;
        }

        static void Main()
        {
            var endDate = DateTime.Parse(Console.ReadLine());
            PrintWorkDays(endDate);
        }
    }
}
