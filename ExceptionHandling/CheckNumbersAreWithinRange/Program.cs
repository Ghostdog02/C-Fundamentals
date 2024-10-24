using System;

namespace CheckNumbersAreWithinRange
{
    public class Program
    {
        static void Main()
        {
            Console.WriteLine($"Enter range start: ");
            int start = int.Parse(Console.ReadLine());
            Console.WriteLine($"Enter range end: ");
            int end = int.Parse(Console.ReadLine());
            ReadNumber(start, end);
        }

        static void ReadNumber(int start, int end)
        {
            int currentNumber = 0;
            int lastNumber = 0;
            for (int i = start; i <= end; i++)
            {
                Console.WriteLine($"Enter number: ");
                try
                {
                    currentNumber = int.Parse(Console.ReadLine());
                }

                catch (FormatException)
                {
                    Console.WriteLine($"Invalid Number");
                    throw new FormatException();
                }

                finally
                {
                    if (currentNumber <= 1 || currentNumber >= 100)
                    {
                        Console.WriteLine($"The number {currentNumber} isn't within the range[1-100]");
                        throw new ArgumentOutOfRangeException();
                    }

                    if (currentNumber < lastNumber)
                    {
                        Console.WriteLine($"The number {currentNumber} is smaller than the last number {lastNumber}");
                        throw new ArgumentException();
                    }
                }
                lastNumber = currentNumber;


            }
        }
    }
}
