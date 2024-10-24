using System.Text.RegularExpressions;

namespace Program
{
    public class RemoveEveryWordThatStartsWithTest
    {
        static void Main()
        {
            string fileName = "Test.txt";
            string fileNameTemp = "TestTemp.txt";
            RemoveWord(fileName, fileNameTemp);
            CopyTextFile(fileName, fileNameTemp);
        }

        static void RemoveWord(string fileName, string fileNameTemp)
        {
            File.Create(fileNameTemp).Close();
            var reader = new StreamReader(fileName);
            var writer = new StreamWriter(fileNameTemp);
            string? line;
            Regex regex = new Regex(@"\btest\w+");
            while ((line = reader.ReadLine()) != null)
            {
                line = regex.Replace(line, "");
                line = line.Trim();
                writer.WriteLine(line);
            }

            reader.Close();
            writer.Close();
        }

        static void CopyTextFile(string fileName, string fileNameTemp)
        {
            File.Create(fileName).Close();
            var reader = new StreamReader(fileNameTemp);
            var writer = new StreamWriter(fileName);
            string? line;

            while ((line = reader.ReadLine()) != null)
            {
                writer.WriteLine(line);
            }
            reader.Close();
            writer.Close();
            File.Delete(fileNameTemp);
        }
    }
}