namespace Program
{
    public class FindOccurrencesOfNumbersInGIvenRange
    {
        static void Main()
        {
            int[] numbers = { 1000, 999, 888, 1000, 999, 999, 888, 765, 999, 1000, 888, 777, 777 };
            //1000 - 3; 999 - 4; 888 - 3; 765 - 1; 777 - 2
            var occurrences = FindOccurrences(numbers);
            WriteOccurrences(occurrences);
        }

        static void WriteOccurrences(int[] numbers)
        {
            for (int i = 0; i < numbers.Length; i++)
            {
                if (numbers[i] > 0)
                {
                    Console.WriteLine($"The number {i} is found {numbers[i]} times");
                }
            }
        }

        static int[] FindOccurrences(int[] numbers)
        {
            //List<int> occurrences = new List<int>(2002);
            int[] occurrences = new int[1001];
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

        //static int[] AddNumbers(int range, int arrLenght)
        //{
        //    Random random = new Random();
        //    int[] numbers = new int[range];
        //    for (int i = 0; i < arrLenght; i++)
        //    {
        //        numbers[i] = random.Next(range + 1);
        //        Console.WriteLine(numbers[i]);
        //    }
        //}
    }
}