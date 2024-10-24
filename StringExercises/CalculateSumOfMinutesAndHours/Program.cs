using System;
using System.Globalization;

namespace CalculateSumOfMinutesAndHours
{
    public class Program
    {
        static void Main()
        {
            var date = DateTime.ParseExact(Console.ReadLine(), "dd.MM.yyyy HH:mm:ss", CultureInfo.CurrentCulture);
            //{dd.MM.yyyy HH:mm:ss}
            date = date.AddHours(6);
            date = date.AddMinutes(30);
            Console.WriteLine("{0:dd.MM.yyyy HH:mm:ss}", date);
            
        }
    }
}
