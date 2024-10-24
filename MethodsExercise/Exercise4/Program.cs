using System;

namespace Exercise4
{
    class Program
    {
        static void Main()
        {
            int[] array = { 2, 3, 3, 3, 4, };
            Console.WriteLine(CountEqualNumbers(3, array)); 
        }
        static int CountEqualNumbers(int number, params int[] array)
        {
            int count = 0;
            for (int index = 0; index < array.Length; index++)
            {
                if (number == array[index])
                {
                    count++;
                }
            }
            return count;
        }
    }
}
