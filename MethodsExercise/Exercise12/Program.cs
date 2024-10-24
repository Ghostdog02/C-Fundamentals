using System;

namespace Exercise12
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] polinom1 = { 3, 4, 5, 6, 7, 9 };
            int[] polinom2 = { 4, 5, 6, 7 };
            CalculatePolinoms(polinom1, polinom2);
        }
        static void CalculatePolinoms(int[] polinom1, int[] polinom2)
        {
            int maxLenght = Math.Max(polinom1.Length, polinom2.Length);
            int[] result = new int[maxLenght];
            for (int i = 0; i < maxLenght; i++)
            {
                // Check if index "i" is an element of the two arrays
                int num1 = polinom1.Length > i ? polinom1[i] : 0;
                int num2 = polinom2.Length > i ? polinom2[i] : 0;
                result[i] = num1 + num2;

            }
            PrintPolinoms(result);
        }
        static void PrintPolinoms(int[] result)
        {
            int lenght = result.Length;
            int[] reversed = new int[lenght];
            for (int index = 0; index < lenght; index++)
            {
                reversed[lenght - index - 1] = result[index];
            }
            for (int index = 0; index < lenght; index++)
            {
                if (index == lenght - 1)
                {
                    Console.Write($"{reversed[index]}");
                }
                else if (index == lenght - 2)
                {
                    Console.Write($"{reversed[index]} * x + ");
                }
                else
                {
                    Console.Write($"{reversed[index]} * x{lenght - index - 1} + ");
                }
                
            }

        }
    }
}
