using System;

namespace GenerateVaritionWithNIterationsOfKClass
{
    public class Program
    {
        private static int currentLoop = 1;
        private static int numberOfLoops = 0;
        private static int iterations = 0;
        private static int[] loops;

        static void Main()
        {
            numberOfLoops = 2;
            iterations = 3;
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

            for (int i = 1; i <= iterations; i++)
            {
                loops[currentLoop] = i;
                NestedLoops(currentLoop + 1);
            }
        }

        static void PrintNumber(int iterations)
        {
            for (int i = 0; i < iterations; i++)
            {
                if (i == iterations - 1)
                    Console.Write($"{loops[i]}), ");
                else
                    Console.Write($"({loops[i]} ");
            }

        }
    }
}
