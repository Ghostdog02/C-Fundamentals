using System;

namespace Exercise3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write($"Enter number: ");
            int number = int.Parse(Console.ReadLine());
            Console.WriteLine(PrintName(number));
        }
        static string PrintName(int number)
        {
            number %= 10;
            string numberName = null;
            switch (number)
            {
                case 0:
                    numberName = "zero";
                    break;
                case 1:
                    numberName = "one";
                    break;
                case 2:
                    numberName = "two";
                    break;
                case 3:
                    numberName = "three";
                    break;
                case 4:
                    numberName = "four";
                    break;
                case 5:
                    numberName = "five";
                    break;
                case 6:
                    numberName = "six";
                    break;
                case 7:
                    numberName = "seven";
                    break;
                case 8:
                    numberName = "eight";
                    break;
                case 9:
                    numberName = "nine";
                    break;
                default:
                    Console.WriteLine($"Invalid number!");
                    break;
            }
            return numberName;

        }
    }
}
