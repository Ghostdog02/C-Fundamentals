using System;
using System.Numerics;

namespace Factorial
{
    public class Program
    {
        static void Main()
        {
            BigInteger n = 99999;
            Console.WriteLine(CalculateFactoriel(n));
        }

        static BigInteger CalculateFactoriel(BigInteger n)
        {
            BigInteger result = 1;
            for (BigInteger i = 1; i <= n; i++)
            {
                result *= i;
            }
            return result;
        }
    }
}
