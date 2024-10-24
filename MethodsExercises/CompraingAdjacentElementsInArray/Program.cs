using System;

namespace CompraingAdjacentElementsInArray
{
    public class Program
    {
        static void Main()
        {
            int n = 9;
            int[] numbers = new int[10];
            Random random = new Random();
            for (int i = 0; i < numbers.Length; i++)
            {
                numbers[i] = random.Next(0, 99);
                if (i == n)
                {
                    CompareAdjacentElements(numbers, i);
                    break;
                }
                //if (i == n - 1 && i != 0)
                //{
                //    adjacentElement1 = numbers[i];
                //}

                //if (i == n + 1 && i != numbers.Length - 1)
                //{
                //    adjacentElement2 = numbers[i];
                //}
            }



        }

        static void CompareAdjacentElements(int[] numbers, int index)
        {
            //var result = (n > adjacentElement1 && n > adjacentElement2) ? "N is bigger" : "N is smaller";
            //Console.WriteLine(result);
            bool isFirst = (index == 0) ? true : false;
            bool isLast = (index == numbers.Length - 1);
            if (isFirst)
            {
                var result = (numbers[index] > numbers[index + 1]) ? $"{numbers[index]} is bigger than {numbers[index + 1]}" :
                    $"{numbers[index]} is smaller than {numbers[index + 1]}";
                Console.WriteLine(result);
            }

            else if (isLast)
            {
                var result = (numbers[index] > numbers[index - 1]) ? $"{numbers[index]} is bigger than {numbers[index - 1]}" :
                     $"{numbers[index]} is smaller than {numbers[index - 1]}";
                Console.WriteLine(result);

            }

            else
            {
                var result = (numbers[index] > numbers[index - 1] && numbers[index] > numbers[index + 1]) ?
                    $"{numbers[index]} is bigger than {numbers[index - 1]} and {numbers[index + 1]}" :
                    $"{numbers[index]} is smaller than {numbers[index - 1]} and {numbers[index + 1]}";
                Console.WriteLine(result);
            }
        }
    }
}
