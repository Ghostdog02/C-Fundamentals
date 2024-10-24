using System;

namespace CalculatingSquareRoot
{
    class Program
    {
        static void Main()
        {
            try
            {
                int number = int.Parse(Console.ReadLine());
                if (number < 0)
                {
                    Console.WriteLine($"Invalid number!");
                    return;
                }
                CalculateSquareRoot(number);
            }
            catch (FormatException)
            {
                Console.WriteLine($"Invalid number!");
            }
            finally
            {
                Console.WriteLine($"Good bye.");
            }
        }
        static void CalculateSquareRoot(int number)
        {
            double squareRoot = Math.Sqrt(number);
            Console.WriteLine(squareRoot);
        }
    }
}
