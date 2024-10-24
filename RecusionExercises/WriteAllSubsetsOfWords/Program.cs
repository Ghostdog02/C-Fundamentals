using System;

namespace WriteAllSubsetsOfWords
{
    public class Program
    {
        private static int currentLoop = 1;
        private static int numberOfLoops = 0;
        private static int iterations = 0;
        private static int[] loops;
        static readonly string[] words = new string[] { "test", "rock", "fun" };

        static void Main()
        {
            numberOfLoops = 2;
            iterations = 3;
            int factoriel = 1;
            loops = new int[words.Length];
            Console.Write("(), ");
            NestedLoops(0);
            Console.Write("(");
            foreach (var word in words)
            {
                Console.Write($"{word} ");
            }
            Console.Write(")");
        }

        static void NestedLoops(int currentLoop)
        {
            if (currentLoop == numberOfLoops)
            {
                PrintNumber(numberOfLoops);
                return;
            }

            for (int i = 0; i < iterations; i++)
            {
                loops[currentLoop] = i;
                NestedLoops(currentLoop + 1);
            }
        }

        static void PrintNumber(int iterations)
        {
            for (int i = 0; i < iterations; i++)
            {
                if (loops[0] == loops[1])
                {
                    Console.Write($"({words[loops[i]]}), ");
                    i++;
                }

                else
                {
                    if (i == numberOfLoops - 1)
                        Console.Write($"{words[loops[i]]}), ");

                    else
                        Console.Write($"({words[loops[i]]} ");
                }
            }

        }
    }
}
