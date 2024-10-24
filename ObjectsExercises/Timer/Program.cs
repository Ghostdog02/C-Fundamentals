using System;

namespace Timer
{
    class Program
    {
        public static void Main(string[] args)
        {
            int number = 0;
            int startTime = Environment.TickCount;
            for (int i = 0; i < 10000000; i++)
            {
                number++;

            }
            int endTime = Environment.TickCount;
            //int seconds = (startTime - endTime) / 1000;
            double finalTimeMinutes = ((endTime - startTime) / 1000.0) / 60.0;
            double finalTimeHours = finalTimeMinutes / 60.0;
            double finalTimeDays = finalTimeHours / 24.0;
            //int minutes = seconds / 60;
            //int hours = minutes / 60;
            //int days = hours / 24;
            Console.WriteLine($"Time elapsed: {finalTimeDays} : {finalTimeHours} : {finalTimeMinutes} ");
        }
    }
}
