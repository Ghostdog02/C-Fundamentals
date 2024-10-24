using System;

namespace WriteAllSubsetsOfKNumberStrings
{
    public class Program
    {
        private static int currentLoop = 1;
        private static int numberOfLoops = 0;
        private static int numberOfIterations = 0;
        private static int[] loops;
        static readonly string[] words = new string[] { "test", "rock", "fun" };


        static void Main(string[] args)
        {
            int k = 2;
            numberOfLoops = k;
            numberOfIterations = words.Length;
            loops = new int[numberOfLoops];
            NestedLoops(0, 0);

        }

        static void NestedLoops(int currentLoop, int start)
        {
            if (currentLoop == numberOfLoops)
            {
                PrintNumber(numberOfLoops);
                return;
            }

            for (int i = start; i < numberOfIterations; i++)
            {
                loops[currentLoop] = i;
                NestedLoops(currentLoop + 1, i + 1);
            }
        }

        static void PrintNumber(int numberOfLoops)
        {
            for (int i = 0; i < numberOfLoops; i++)
            {
                if (i == numberOfLoops - 1)
                    Console.Write($"{words[loops[i]]}), ");
                else
                    Console.Write($"({words[loops[i]]} ");
            }
            
        }
    }
}
