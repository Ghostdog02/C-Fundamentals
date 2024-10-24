using System;

namespace Read10Numbers
{
    public class Program
    {
        public static void Main()
        {
            // 1 - 100

            
            int[] numbers = new int[10];
            int index = 0;
            int start = 2;
            const int end = 99;
            while (index < 10)
            {
                try
                {
                    Console.Write($"{index + 1, 2} ");
                    numbers[index] = ReadNumber(start, end);
                    start = numbers[index] + 1;
                    index++;
                }
                catch (InvalidNumberException ex)
                {
                    Console.WriteLine(ex.Message);
                    Console.WriteLine();
                }
            }

            Console.Write("1");
            foreach (var number in numbers)
            {
                Console.Write($" < {number}");
            }
            Console.Write(" < 100");
        }

        public static int ReadNumber(int start, int end)
        {
            Console.Write($"Input number [{start}..{end}]: ");
            var input = Console.ReadLine();
            int number;
            if (!int.TryParse(input, out number))
            {
                throw new InvalidNumberException("Invalid format");
            }

            if (number < start || number > end)
            {
                throw new InvalidNumberException($"Number {number} is outside of the range [{start}..{end}]");
            }

            return number;
        }
    }

    public class InvalidNumberException : Exception
    {
        public InvalidNumberException(string message) : base(message)
        {
        }
    }
}
