using System.Text.RegularExpressions;

namespace Program
{
    public class ReplaceSubstring
    {
        static void Main()
        {
            var fileName = "Example.txt";
            var fileNameTemp = "Example1.txt";
            Replace(fileName);
            CopyTextFile(fileName, fileNameTemp);

        }

        static void Replace(string fileName)
        {
            var fileNameTemp = "Example1.txt";
            File.Create(fileNameTemp).Dispose();
            var reader = new StreamReader(fileName);
            var writer = new StreamWriter(fileNameTemp);
            string? line;
            Regex regex = new Regex(@"\b(start)\b");
            while ((line = reader.ReadLine()) != null)
            {
                line = regex.Replace(line, "finish");
                writer.WriteLine(line);
            }

            reader.Close();
            writer.Close();
        }

        static void CopyTextFile(string fileName, string fileNameTemp)
        {
            File.Create(fileName).Dispose();
            var reader = new StreamReader(fileNameTemp);
            using var writer = new StreamWriter(fileName);
            string? line;
            while ((line = reader.ReadLine()) != null)
            {
                writer.WriteLine(line);
            }

            reader.Close();
            File.Delete(fileNameTemp);
        }
    }
}