using System;

namespace PermutateNumbersToN
{
    public class Program
    {
        static void Main()
        {
            int n = 3;
            int k = 3;
            int[] p = new int[k];
            int counter = 1;
            for (int i = 0; i < k; i++)
            {
                p[i] = counter;
                counter++;
            }

            Perm(k - 1, p, n);
        }

        static void Perm(int k, int[] p, int n)
        {
            if (k == 0)
            {
                //DO somehting:
                PrintNumber(n, p);
                return;
            }

            Perm(k - 1, p, n);

            for (int i = 0; i < k; i++)
            {
                int temp = p[i];
                p[i] = p[k];
                p[k] = temp;
                Perm(k - 1, p, n);
                temp = p[i];
                p[i] = p[k];
                p[k] = temp;
            }
        }

        static void PrintNumber(int iterations, int[] p)
        {
            for (int i = 0; i < iterations; i++)
            {
                if (i == iterations - 1)
                    Console.Write($"{p[i]}), ");
                else if (i == 0)
                    Console.Write($"({p[i]} ");
                else
                    Console.Write($"{p[i]} ");

            }

        }
    }
}
