namespace Program
{
    public class FindMajorant
    {
        static void Main()
        {
            int[] numbers = new int[] { 2, 2, 3, 3, 2, 3, 4, 3, 3 };
            int majorant = (numbers.Length / 2) + 1;
            int[] occurrences = FindOccurrences(numbers);
            int[] occurrences1 = FindOccurrences(numbers);
            int result = CalculateMajorant(occurrences, occurrences1, majorant);
            if (result != 0)
                Console.WriteLine(result);
            else Console.WriteLine("The majorant does not exists!.");
        }

        static int[] FindOccurrences(int[] numbers)
        {
            //List<int> occurrences = new List<int>(2002);
            int[] occurrences = new int[numbers.Length];
            for (int i = 0; i < numbers.Length; i++)
            {
                var number = numbers[i];
                if (occurrences[number] >= 1)
                {
                    occurrences[number]++;
                }

                else
                {
                    occurrences[number] = 1;
                }
            }

            return occurrences;
        }

        static int CalculateMajorant(int[] occurrences, int[] occurrencesUnsorted, int majorant)
        {
            int result = 0;
            Array.Sort(occurrences);
            for (int i = occurrences.Length - 1; i > 0; i--)
            {
                if ((occurrences[i] <= majorant) && (occurrences[i] != 0))
                {
                    for (int j = 0; j < occurrencesUnsorted.Length; j++)
                    {
                        if (occurrences[i] == occurrencesUnsorted[j])
                        {
                            result = j; break;
                        }
                    }

                    break;
                }
            }

            return result;

        }
    }
}