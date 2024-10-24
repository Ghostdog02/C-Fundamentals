namespace Program
{
    public class SortNamesInAscendingOrder
    {
        static void Main()
        {
            var fileName = "Names.txt";
            var list = ReadNames(fileName);
            var sortedList = SortNames(list);
            WriteNames(sortedList);
        }

        static List<string> ReadNames(string fileName)
        {
            using var reader = new StreamReader(fileName, encoding: System.Text.Encoding.ASCII);
            string? line;
            List<string> names = new();
            while ((line = reader.ReadLine()) != null)
            {
                names.Add(line);
            }
            return names;
        }

        static List<string> SortNames(List<string> names)
        {
            names = names.OrderBy(x => x).ToList();
            return names;
        }

        static void WriteNames(List<string> names)
        {
            string fileName = "SortedNames.txt";
            File.Create(fileName).Dispose();
            using var writer = new StreamWriter(fileName);
            for (int i = 0; i < names.Count; i++)
            {
                writer.WriteLine(names[i]);
            }

        }
    }
}