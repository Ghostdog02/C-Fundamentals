using System;
using System.Globalization;

namespace CalculateDaysDifference
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.Write($"Enter first date: ");
            var firstDate = DateTime.ParseExact(Console.ReadLine(), "dd.MM.yyyy", CultureInfo.CurrentCulture);
            Console.Write($"Enter second date: ");
            var secondDate = DateTime.ParseExact(Console.ReadLine(), "dd.MM.yyyy", CultureInfo.CurrentCulture);
            var difference = (secondDate.Date - firstDate.Date).Days;
            Console.WriteLine($"{difference} days");
            
        }
    }
}
