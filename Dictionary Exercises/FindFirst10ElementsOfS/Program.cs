using System.Xml.Linq;
using TreeMultiSetImplementation;

namespace FindFirst10ElementsOfS
{
    public class Program
    {
        static void Main(string[] args)
        {
            int[] givenSequence = { 1, 1, 2, 1, -1, 2, 3, -1, 1, 2, 3, 5, 1, -1, 2, 3 };
            int n = 5;
            var set = FindLuckySubSequences(givenSequence, n);
            RemoveElements(set);
            PrintSequences(set);
        }

        static TreeMultiSet<Sequence> FindLuckySubSequences(int[] givenSequence, int n)
        {
            var set = new TreeMultiSet<Sequence>();
            for (int i = 0; i < givenSequence.Length; i++)
            {
                var sequence = new Sequence();
                int sum = givenSequence[i];
                sequence.Add(sum);
                if (sum == 5)
                {
                    var s = new Sequence();
                    s.AddRange(sequence);
                    set.Add(s);
                }

                for (int j = i + 1; j < givenSequence.Length; j++)
                {
                    sequence.Add(givenSequence[j]);
                    sum += givenSequence[j];
                    if (sum == 5)
                    {
                        var s = new Sequence();
                        s.AddRange(sequence);
                        set.Add(s);
                    }
                }
            }

            return set;
        }

        static void PrintSequences(TreeMultiSet<Sequence> set)
        {

            foreach (var s in set)
            {
                foreach (var element in s.Key)
                {
                    Console.Write(element);
                    Console.Write(" ");
                }

                Console.WriteLine();
                //Duplicates

                foreach (var sequence in s.Value)
                {
                    foreach (var number in sequence)
                    {
                        Console.Write(number);
                        Console.Write(" ");
                    }
                    Console.WriteLine();
                }

            }
        }

        static void RemoveElements(TreeMultiSet<Sequence> set)
        {
            while (set.Count != 10)
            {
                var lastSequence = set.Last();
                set.RemoveElement(lastSequence);
            }
        }
    }
}