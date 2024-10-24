using System;

namespace LeapYear
{
    public class LeapYear
    {
        public int Year { get; set; }

        public bool CheckYear()
        {
            return (Year % 4 == 0 && Year % 100 != 0) || (Year % 400 == 0 && Year % 100 == 0);

        }

    }

    public class Program
    {
        public static void Main()
        {
            LeapYear leapYear = new LeapYear();
            leapYear.Year = int.Parse(Console.ReadLine());
            if (leapYear.CheckYear())
            {
                Console.WriteLine($"{leapYear.Year} is a leap year.");
            }
            else
            {
                Console.WriteLine($"{leapYear.Year} isn't a leap year.");
            }
        }
    }

}
