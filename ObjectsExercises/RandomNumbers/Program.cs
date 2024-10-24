using System;
using System.Collections.Generic;

namespace RandomNumbers
{
    public class RandomNumbers
    {
        public static void Main()
        {
            Random random = new Random();
            List<int> numbers = new List<int>();
            for (int i = 0; i < 100000; i++)
            {
                numbers.Add(random.Next(100) + 100);
            }
            foreach (var number in numbers)
            {
                Console.WriteLine(number);
            }
        }

    }
}
