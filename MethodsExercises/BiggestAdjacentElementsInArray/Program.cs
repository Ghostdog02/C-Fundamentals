using System;

namespace BiggestAdjacentElementsInArray
{
    public class Program
    {
        static void Main()
        {
            int[] numbers = new int[10];
            Random random = new Random();
            int index = -1;
            for (int i = 0; i < numbers.Length - 1; i++)
            {
                numbers[i] = random.Next(0, 99);
                index = GetAdjacentElementsIndex(numbers, i);
                if (index != -1)
                {
                    break;
                }

            }
            Console.WriteLine(index);
        }

        static int GetAdjacentElementsIndex(int[] numbers, int index)
        {
            bool isFirst = (index == 0) ? true : false;
            bool isLast = (index == numbers.Length - 1);
            if (isFirst)
            {
                return (numbers[index] > numbers[index + 1]) ? index : -1;
            }

            else if (isLast)
            {
                return (numbers[index] > numbers[index - 1]) ? index : -1;

            }

            else
            {
                return (numbers[index] > numbers[index - 1] && numbers[index] > numbers[index + 1]) ? index : -1;
            }

        }
    }
}
