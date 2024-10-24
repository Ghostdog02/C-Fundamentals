using System;
using System.Collections.Generic;

namespace ReverseNumber
{
    public class Program
    {
        static void Main()
        {
            int n = 652;
            int reversedNumber = ReverseNumber(n);
            Console.WriteLine(reversedNumber);

        }

        static int ReverseNumber(int n)
        {
            string reversedNumber = "";
            while (n > 0)
            {
                reversedNumber += (n % 10);
                n /= 10;
            }

            return Int32.Parse(reversedNumber);

        }
    }
}
