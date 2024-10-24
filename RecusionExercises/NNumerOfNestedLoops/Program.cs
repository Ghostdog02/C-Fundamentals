using System;

namespace NNumerOfNestedLoops
{
    public class Program
    {
        private static int currentLoop = 1;
        private static int numberOfLoops = 0;
        private static int[] loops;

        static void Main()
        {
            numberOfLoops = 3;
            loops = new int[numberOfLoops];
            NestedLoops(0);
        }

        static void NestedLoops(int currentLoop)
        {
            if (currentLoop == numberOfLoops)
            {
                PrintNumber(numberOfLoops);
                return;
            }

            for (int i = 1; i <= numberOfLoops; i++)
            {
                loops[currentLoop] = i;
                NestedLoops(currentLoop + 1);
            }
        }

        static void PrintNumber(int numberOfLoops)
        {
            for (int i = 0; i < numberOfLoops; i++)
            {
                Console.Write($"{loops[i]} ");
            }
            Console.WriteLine();
        }
    }
}
