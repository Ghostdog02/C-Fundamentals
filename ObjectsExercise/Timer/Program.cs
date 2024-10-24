using System;

namespace Timer
{
    class Program
    {
        static void Main()
        {
            int sum = 0;
            decimal startTime = Environment.TickCount;
            for (int i = 0; i < 10000000; i++)
            {
                sum++;
            }
            decimal endTime = Environment.TickCount;
            decimal time = (endTime - startTime) / 1000;
            Console.WriteLine($"{time} elapsed.");
            
        }
    }
}
