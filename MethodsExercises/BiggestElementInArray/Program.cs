using System;

namespace BiggestElementInArray
{
    public class Program
    {
        static void Main()
        {
            int n = 4;
            var numbers = new int[4];
            Random random = new Random();
            for (int i = 0; i < numbers.Length; i++)
            {
                numbers[i] = random.Next(0, 10);
            }
            Console.WriteLine(GetBiggestElement(numbers));
        }

        static int GetBiggestElement(int[] numbers)
        {
            for (int i = 0; i < numbers.Length; i++)
            {
                for (int j = i + 1; j < numbers.Length; j++)
                {
                    if (numbers[i] > numbers[j])
                    {
                        var oldNum = numbers[i];
                        numbers[i] = numbers[j];
                        numbers[j] = oldNum;
                    }
                }
            }
            return numbers[numbers.Length - 1];
        }
    }
}
