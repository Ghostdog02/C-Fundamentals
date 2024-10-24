using System;

namespace Exercise2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write($"Enter number1: ");
            int number1 = int.Parse(Console.ReadLine());
            Console.Write($"Enter number2: ");
            int number2 = int.Parse(Console.ReadLine());
            Console.Write($"Enter number3: ");
            int number3 = int.Parse(Console.ReadLine());
            int max = Math.Max(GetMax(number1, number2), number3);
            Console.WriteLine(max);
        }
        static int GetMax(int number1, int number2)
        {
            int max = Math.Max(number1, number2);
            return max;
        }
    }
}
