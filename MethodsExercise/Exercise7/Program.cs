using System;

namespace Exercise7
{
    class Program
    {
        static void Main(string[] args)
        {
            ReverseNumbers(652);
        }
        static void ReverseNumbers(int number)
        {
            while (number != 0)
            {
                int digit = number % 10;
                number /= 10;
                Console.Write(digit);

            }
            
        }
    }
}
