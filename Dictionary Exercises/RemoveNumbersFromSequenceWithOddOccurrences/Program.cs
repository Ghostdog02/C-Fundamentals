namespace RemoveNumbersFromSequenceWithOddOccurrences
{
    public class Program
    {
        static void Main(string[] args)
        {
            var sequence = new List<int> { 4, 2, 2, 5, 2, 3, 2, 3, 1, 5, 2, 6, 6, 6 };
            var occurrences = new Dictionary<int, int>();
            foreach (var num in sequence)
            {
                if (occurrences.ContainsKey(num))
                {
                    occurrences[num]++;
                }

                else
                {
                    occurrences[num] = 1;
                }
            }

            foreach (var pair in occurrences)
            {
                if (pair.Value % 2 != 0)
                {
                    sequence.RemoveAll(x => x == pair.Key);
                }
            }

            foreach (var num in sequence)
            {
                Console.WriteLine(num);
            }
        }
    }
}