using System;

namespace RandomGenerator
{
    class Program
    {
        static void Main()
        {
            Random rand = new Random();
            for (int number = 1; number <= 10; number++)
            {
                int randomNumber = rand.Next(100) + 100;
                Console.Write("{0} ", randomNumber);
            }

        }
    }
}
