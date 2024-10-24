using System.Text.RegularExpressions;

namespace Program
{
    public class XMLFileGetText
    {
        static void Main()
        {
            string fileName = "XMLFile.txt";
            List<string> text = GetText(fileName);
            PrintText(text);
        }

        static List<string> GetText(string fileName)
        {
            List<string> text = new List<string>();
            using var reader = new StreamReader(fileName);
            string? line;
            Regex regex = new Regex(@"([^>])[^<>]+(?=[<])");

            while ((line = reader.ReadLine()) != null)
            {
                var matches = regex.Matches(line);
                foreach (Match match in matches)
                {
                    text.Add(match.Value);
                }
            }

            return text;
        }

        static void PrintText(List<string> text)
        {
            foreach (string line in text)
            {
                Console.WriteLine(line);
            }
        }
    }
}