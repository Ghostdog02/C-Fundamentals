using System;

namespace CalculateTimePassedForAProgram
{
    public class Program
    {
        static void Main()
        {
            double start = Environment.TickCount;
            int sum = 0;
            for (int i = 0; i < 1000000; i++)
            {
                sum += i;
            }
            double end = Environment.TickCount;
            Console.WriteLine((end - start)/1000d);
        }
    }
}
