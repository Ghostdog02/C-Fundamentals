using System;

namespace Exrcise8
{
    class Program
    {
        static void Main()
        {
            int[] firstNumber = { 2, 3, 4,};
            int[] secondNumber = { 2, 3, 4,};
            CalculateSumOfArrays(firstNumber, secondNumber); 


        }
        static void CalculateSumOfArrays(int[] firsNumber, int[] secondNumber)
        {
            int sum = 0;
            //int remainder = 0;
            for (int index = 0; index < firsNumber.Length; index++)
            {
                int internalSum = firsNumber[index] + secondNumber[index];
                sum += internalSum * (int)Math.Pow(10, index);
            }

            //Console.WriteLine(sum + (firsNumber[index] + secondNumber[index]) % 10);
            Console.WriteLine($"The sum is {sum}");
        }
    }
}
