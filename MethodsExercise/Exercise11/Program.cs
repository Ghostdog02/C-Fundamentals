using System;

namespace Exercise11
{
    class Program
    {
        static void Main()
        {
            Console.Write($"Choose task(reversing number, average of an array, calculating linear equation): ");
            string task = Console.ReadLine().ToLower();
            if (task == "reversing number")
            {
                Console.Write($"Enter number: ");
                int number = int.Parse(Console.ReadLine());
                if (number < 0)
                {
                    Console.WriteLine($"{number} is negative!");
                    return;
                }
                ReversingNumber(number);


            }
            else if (task == "average of an array")
            {
                Console.WriteLine($"Enter number of elements in the sequence: ");
                int n = int.Parse(Console.ReadLine());
                int[] sequence = new int[n];
                for (int index = 0; index < sequence.Length; index++)
                {
                    Console.Write($"Enter sequence[{index}]:");
                    sequence[index] = int.Parse(Console.ReadLine());
                    if (sequence[index] == 0)
                    {
                        Console.WriteLine($"The element of the array is empty!");
                        return;
                    }
                    
                }
                AverageOfAnArray(sequence);
            }
            else
            {
                Console.WriteLine($"Enter a: ");
                int a = int.Parse(Console.ReadLine());
                if (a == 0)
                {
                    Console.WriteLine($"a is zero!");
                    return;
                }
                Console.WriteLine($"Enter x: ");
                int x = int.Parse(Console.ReadLine());
                Console.WriteLine($"Enter b: ");
                int b = int.Parse(Console.ReadLine());
                CalculatingLinearEquation(a, x, b);
            }
        }
        static void ReversingNumber(int number)
        {
            while (number != 0)
            {
                int digit = number % 10;
                number /= 10;
                Console.Write(digit);

            }
        }
        static void AverageOfAnArray(int[] sequence)
        {
            int sum = 0;
            for (int index = 0; index < sequence.Length; index++)
            {
                sum = sum + sequence[index];
            }
            double average = sum / sequence.Length;
            Console.WriteLine(average);
        }
        static void CalculatingLinearEquation(int a, int x, int b)
        {
            int linearEquation = (a * x) + b;
            Console.WriteLine(linearEquation);
        }
    }
}
