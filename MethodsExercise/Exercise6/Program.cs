using System;

namespace Exercise6
{
    class Program
    {
        static void Main()
        {
            CheckBiggerNumber(1, 2, 3, 4, 3, 6);
        }
        static void CheckBiggerNumber(params int[] array)
        {
            bool biggerNumber = false;
            for (int index = 0; index < array.Length - 1; index++)
            {
                if (array[index] > array[index + 1])
                {
                    Console.WriteLine(array[index]);
                    biggerNumber = true;
                }
            }
            CheckIfBiggerNumberFalse(biggerNumber);

        }
        static void CheckIfBiggerNumberFalse(bool biggerNumber)
        {
            if (biggerNumber == false)
            {
                Console.WriteLine(-1);
            }
        }

    }
}
