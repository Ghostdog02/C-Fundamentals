using System;

namespace TodaysDay
{
    class Program
    {
        static void Main()
        {
            DateTime today = DateTime.Today;
            var dayOftheweek = today.DayOfWeek;
            Console.WriteLine(dayOftheweek);
        }
    }
}
