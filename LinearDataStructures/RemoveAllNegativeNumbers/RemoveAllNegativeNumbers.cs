namespace Program
{
    public class RemoveAllNegativeNumbers
    {
        static void Main()
        {
            var numbers = new int[] { 1, -1, 2, 3, 4, 5 };
            List<int> list = new(numbers);
            for (int i = 0; i < list.Count; i++)
            {
                if (list[i] < 0)
                    list.RemoveAt(i);
            }

            foreach (int i in list)
            {
                Console.WriteLine(i);
            }
        }
    }
}