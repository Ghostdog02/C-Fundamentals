using System;

namespace SolveDifferentTasks
{
    public class Program
    {
        private static int InputNumber(Func<int, bool> validator, string message, string message1 = "")
        {
            Console.WriteLine(message);
            var number = Int32.Parse(Console.ReadLine());
            while (!validator(number))
            {
                Console.WriteLine(message1);
                number = Int32.Parse(Console.ReadLine());
            }

            return number;
        }

        private static int[] InputArrayNumbers(int count)
        {
            int[] sequence = new int[count];
            for (int i = 0; i < sequence.Length; i++)
            {
                sequence[i] = InputNumber((num) => num >= 0, $"Enter number [{i}]: ", $"Enter non-negative intiger: ");
            }
            return sequence;
        }

        static void Main()
        {
            Console.WriteLine($"Choose 1 task: reverse number, calculate average, solve linear equation");
            var task = Console.ReadLine().ToLower();
            switch (task)
            {
                case "reverse number":
                    var number = InputNumber((num) => num >= 0, $"Enter number: ", $"Enter non-negative intiger: ");
                    int reversedNumber = ReverseNumber(number);
                    Console.WriteLine(reversedNumber);
                    break;

                case "calculate average":
                    var count = InputNumber((num) => num > 0, $"Enter count: ", $"Enter non-negative intiger for count: ");
                    int average = CalculateAverage(InputArrayNumbers(count));
                    Console.WriteLine($"The average of these number is {average}");
                    break;

                case "solve linear equation":
                    int a = InputNumber((num) => num > 0, $"Enter number a: ", $"Enter positive intiger: ");
                    int b = InputNumber((num) => num > 0, $"Enter number b: ", $"Enter positive intiger: ");
                    int x = SolveLinearEqiation(a, b);
                    Console.WriteLine($"X is {x}");

                    break;
                default:
                    break;
            }
        }

        static int ReverseNumber(int n)
        {
            string reversedNumber = "";
            while (n > 0)
            {
                reversedNumber += (n % 10);
                n /= 10;
            }

            return Int32.Parse(reversedNumber);

        }

        static int CalculateAverage(int[] sequence)
        {
            var sum = 0;
            for (int i = 0; i < sequence.Length; i++)
            {
                sum += sequence[i];
            }
            return sum / sequence.Length;
        }

        static int SolveLinearEqiation(int a, int b)
        {
            int x = -b / a;
            return x;
        }

    }
}
