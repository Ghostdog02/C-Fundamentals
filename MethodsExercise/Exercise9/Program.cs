using System;

namespace Exercise9
{
    class Program
    {
        static void Main()
        {
            Console.Write($"Enter the start of sequence: ");
            int startIndex = int.Parse(Console.ReadLine());
            Console.Write($"Enter the end of sequence: ");
            int endIndex = int.Parse(Console.ReadLine());
            FindMaxValue(startIndex, endIndex, 3, 4, 5, 7);
        }
        static void FindMaxValue(int startIndex, int endIndex, params int[] numbers)
        {
            int maxValue = numbers[startIndex];
            for (int i = startIndex; i < endIndex; i++)
            {
                if (numbers[i + 1] > numbers[i])
                {
                    maxValue = numbers[i + 1];
                }
            }
            Console.WriteLine(maxValue);
        }
    }
}
