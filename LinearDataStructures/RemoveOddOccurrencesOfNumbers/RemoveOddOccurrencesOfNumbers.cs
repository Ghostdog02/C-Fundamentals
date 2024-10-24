namespace Program
{
    public class RemoveOddOccurrencesOfNumbers
    {
        static void Main(string[] args)
        {
            var numbers = new int[] { 4, 2, 2, 5, 2, 3, 2, 3, 1, 5, 2 };
            var occurrences = GetOccurrences(numbers);
            RemoveNumbers(numbers, occurrences);
            var removedNumbers = AddOccurrences(occurrences, numbers);
        }

        static void RemoveNumbers(int[] numbers, Dictionary<int, int> occurrences)
        {

            foreach (var number in occurrences)
            {
                if (number.Value % 2 != 0)
                {
                    occurrences.Remove(number.Key);
                }
            }
        }

        static List<int> AddOccurrences(Dictionary<int,int> occurrences, int[] numbers)
        {
            List<int> list = new List<int>();

            for (int i = 0; i < numbers.Length; i++)
            {
                if (occurrences.ContainsKey(numbers[i]))
                {
                    list.Add(numbers[i]);
                    Console.WriteLine(numbers[i]);
                }
            }

            return list;
        }
        

        static Dictionary<int, int> GetOccurrences(int[] numbers)
        {
            Dictionary<int, int> occurrences = new();
            foreach (int number in numbers)
            {
                if (occurrences.ContainsKey(number))
                    occurrences[number]++;
                else
                    occurrences[number] = 1;
            }

            return occurrences;
        }
    }
}