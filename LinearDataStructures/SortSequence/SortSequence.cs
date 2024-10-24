namespace CalculateAverageAndSumOfSequence
{
    public class SortSequence
    {
        static void Main(string[] args)
        {
            string? line = "";
            DynamicList list = new DynamicList();

            while (true)
            {
                line = Console.ReadLine();
                if (line == "") break;

                list.Add(line);
            }

            list.Sort(list);

            for (int i = 0; i < list.Count; i++)
            {
                Console.WriteLine(list[i]);
            }
        }
    }
}