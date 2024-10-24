using System;

namespace SumOfSequence
{
    public class SumOfSequence
    {
        public string Sequence { get; set; }

        public string[] SplitSequence()
        {
            return Sequence.Split(' '); 
        }

        public void CalculateSum()
        {
            string[] numbers = SplitSequence();
            int sum = 0;
            for (int i = 0; i < numbers.Length; i++)
            {
                sum += Int32.Parse(numbers[i]);
            }
            Console.WriteLine(sum);
        }
    }

    public class Program
    {
        static void Main()
        {
            SumOfSequence sumOfSequence = new SumOfSequence();
            sumOfSequence.Sequence = Console.ReadLine();
            sumOfSequence.CalculateSum();
        }
    }
}
