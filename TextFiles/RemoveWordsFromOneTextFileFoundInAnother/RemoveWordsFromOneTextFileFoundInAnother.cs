using System.Text.RegularExpressions;

namespace Program
{
    public class RemoveWordsFromOneTextFileFoundInAnother
    {
        static void Main(string[] args)
        {
            string fileName1 = "words.txt";
            string fileName2 = "text.txt";
            string fileNameTemp = "textTemp.txt";
            List<string> words = ReadWords(fileName1);
            RemoveWords(fileName2, fileNameTemp, words);
            CopyTextFile(fileName2, fileNameTemp);
        }

        static List<string> ReadWords(string fileName)
        {
            List<string> words = new List<string>();
            try
            {
                var reader = new StreamReader(fileName);
                string? line;

                while ((line = reader.ReadLine()) != null)
                {
                    words.Add(line);
                }

                reader.Close();
                return words;
            }

            catch (FileNotFoundException)
            {
                throw new FileNotFoundException($"The file {fileName} wasn't found");
            }

            catch (IOException)
            {
                throw new IOException($"Cannot read file {fileName}");
            }

            catch (UnauthorizedAccessException)
            {
                throw new UnauthorizedAccessException($"You don't have access to the file {fileName}");
            }

        }

        static void RemoveWords(string fileName, string fileNameTemp, List<string> words)
        {
            try
            {
                File.Create(fileNameTemp).Close();
                var reader = new StreamReader(fileName);
                var writer = new StreamWriter(fileNameTemp);
                string? line;

                while ((line = reader.ReadLine()) != null)
                {
                    foreach (var word in words)
                    {
                        if (line.Contains(word))
                        {
                            line = line.Replace(word, "");
                        }
                    }

                    line = line.Trim();
                    line = line.Replace("  ", " ");
                    writer.WriteLine(line);
                }

                reader.Close();
                writer.Close();
            }

            catch (FileNotFoundException)
            {
                throw new FileNotFoundException($"The file {fileName} wasn't found");
            }

            catch (IOException)
            {
                throw new IOException($"Cannot read file {fileName}");
            }

            catch (UnauthorizedAccessException)
            {
                throw new UnauthorizedAccessException($"You don't have access to the file {fileName}");
            }

        }

        static void CopyTextFile(string fileName, string fileNameTemp)
        {
            try
            {
                File.Create(fileName).Close();
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

            catch (FileNotFoundException)
            {
                throw new FileNotFoundException($"The file {fileName} wasn't found");
            }

            catch (IOException)
            {
                throw new IOException($"Cannot read file {fileName}");
            }

            catch (UnauthorizedAccessException)
            {
                throw new UnauthorizedAccessException($"You don't have access to the file {fileName}");
            }

        }
    }
}