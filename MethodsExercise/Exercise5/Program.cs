using System;

namespace Exercise5
{
    class Program
    {
        static void Main()
        {
            Console.Write($"Enter index of array: ");
            int index = int.Parse(Console.ReadLine());
            int[] array = { 2, 3, 4, 8, 6, 5, 8, 9, 10 };
            
            PrintBiggerNumber(index, array);
        }

        static void PrintEdgeCase(int currentNumber, int closeNumber)
        {
            if (currentNumber > closeNumber)
            {
                Console.WriteLine($"The number {currentNumber} is bigger than its close number");
            }
            else if (currentNumber < closeNumber)
            {
                Console.WriteLine($"The number {currentNumber} is smaller than its close number");
            }
            else
            {
                Console.WriteLine($"The number {currentNumber} is equal to its close number");
            }
        }

        static void PrintBiggerNumber(int index, int[] array)
        {
            if (index == 0)
            {
                PrintEdgeCase(array[index], array[index + 1]);
            }
            else if (index == array.Length - 1)
            {
                PrintEdgeCase(array[index], array[index - 1]);
            }
            else
            {
                if (array[index] > array[index + 1] && array[index] > array[index - 1])
                {
                    Console.WriteLine($"The number {array[index]} is bigger than its close numbers");
                }
                else if (array[index] < array[index + 1] && array[index] < array[index - 1])
                {
                    Console.WriteLine($"The number {array[index]} is smaller than its close numbers");
                }
                else
                {
                    Console.WriteLine($"The number {array[index]} isn't either smaller or bigger than its close numbers");
                }
            }
        }
    }
}
