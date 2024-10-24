using System;

namespace ReadStringTo20Cymbols
{
    public class Program
    {
        static void Main()
        {
            string input = Console.ReadLine();
            input = input.PadRight(20, '*');
            Console.WriteLine(input);
        }
    }
}
