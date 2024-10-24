using System;

namespace Generate10RandomNumbersBetween100And200
{
    public class Program
    {
        static void Main()
        {
            GenerateRandomNumbers();
        }

        static void GenerateRandomNumbers()
        {
            Random random = new Random();
            int[] numbers = new int[10];
            for (int i = 0; i < numbers.Length; i++)
            {
                numbers[i] = random.Next(100) + 101;
                Console.WriteLine(numbers[i]);
            }
        }
    }
}
