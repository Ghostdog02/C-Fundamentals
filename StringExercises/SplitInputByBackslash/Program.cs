using System;

namespace SplitInputByBackslash
{
    public class Program
    {
        static void Main(string[] args)
        {
            var input = "one\\two\\three";
            var numbers = input.Split("\\");

        }
    }
}
