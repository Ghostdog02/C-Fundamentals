using System;

namespace CheckNumber
{
    public class Program
    {
        static void Main()
        {
            int number = -1;
            bool invalidNumber = false;
            try
            {
                number = int.Parse(Console.ReadLine());
            }

            catch (FormatException)
            {

                Console.WriteLine($"Invalid Number");
                invalidNumber = true;
            }

            finally
            {
                if (number < 0)
                {
                    if (!invalidNumber)
                        Console.WriteLine($"Invalid Number");
                                       
                }

                else
                {
                    Console.WriteLine($"{Math.Sqrt(number)}");                    
                }
            }
            Console.WriteLine($"Good Bye");

        }
    }
}
