using System;

namespace Exercise1
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine($"Enter name: ");
            string name = Console.ReadLine();
            GreetName(name);
        }
        static void GreetName(string name)
        {
            Console.WriteLine($"Hello, {name}!");
        }
    }
}
