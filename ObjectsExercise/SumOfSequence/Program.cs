using System;


namespace SumOfSequence
{
    class SumOfSequence
    {
        private string sequence;
        
        public string Sequence
        { 
            get { return sequence; }
            set { sequence = value; }
        }

        public string[] SplitSequence()
        {
            return Sequence.Split(' ');

        }
        public void CalculateSum()
        {
            var numbers = SplitSequence();
            int sum = 0;
            for (int i = 0; i < numbers.Length; i++)
            {
                sum += Int32.Parse(numbers[i]);

            }
            Console.WriteLine(sum);
        }
        
    }
    class Program
    {
        static void Main()
        {
           var sequence = new SumOfSequence();
           sequence.Sequence = Console.ReadLine();
           sequence.CalculateSum();
            
        }
    }
}

