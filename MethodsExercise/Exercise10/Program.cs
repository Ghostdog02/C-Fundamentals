using System;
using System.Numerics;

namespace Exercise10
{
    class Program
    {
        static void Main()
        {
            Console.Write($"Enter n: ");
            BigInteger n = BigInteger.Parse(Console.ReadLine());
            CalculateFactorial(n);
        }
        static void CalculateFactorial(BigInteger n)
        {
            BigInteger factorial = 1;
            for (BigInteger i = 1; i <= n; i++)
            {
                factorial = factorial * i;
            }
            Console.WriteLine(factorial);
        }
    }
}
