using System.Collections.Specialized;

namespace CalculateOccurrencesOfNumbers
{
    public class Program
    {
        static void Main(string[] args)
        {
            var arr = new[] { 3, 4, 4, 2, 3, 3, 4, 3, 2 };
            var occurrences = new SortedDictionary<int,int>();
            foreach (var item in arr)
            {
                if (occurrences.ContainsKey(item))
                {
                    occurrences[item]++;
                }

                else
                {
                    occurrences[item] = 1;
                }
            }

            foreach (var item in occurrences)
            {
                Console.WriteLine($"Num {item.Key}: {item.Value}");
            }
        }
    }
}