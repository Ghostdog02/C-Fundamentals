namespace Program
{
    public class FindBiggestSequenceWithEqualNumbers
    {
        static void Main(string[] args)
        {
            List<int> numbers = new List<int>();
            string? line = "";

            while (true)
            {
                line = Console.ReadLine();
                if (line == "") break;
                numbers.Add(int.Parse(line));
            }

            var sequence = FindSequence(numbers);
            foreach (int i in sequence)
            {
                Console.WriteLine(i);
            }
        }

        static List<int> FindSequence(List<int> numbers)
        {
            //int nextNum;
            int prevNum = 0;
            List<int> sequence = new List<int>();
            numbers.Sort();

            for (int i = 0; i < numbers.Count; i++)
            {
                if (i == 0)
                {
                    sequence.Add(numbers[i]);
                    prevNum = numbers[i];
                    continue;
                }

                if (numbers[i] == prevNum)
                {
                    sequence.Add(numbers[i]);
                    prevNum = numbers[i];
                }
            }

            if (sequence.Count == 1) //There are no equal numbers
            {
                sequence.Clear();
            }

            return sequence;
        }
    }
}