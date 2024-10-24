using System;
using System.Collections.Generic;
using System.IO;

namespace Program
{
    public class FindOccurrencesOfWordsAndWriteResult
    {
        static void Main(string[] args)
        {
            string fileName1 = "words.txt";
            string fileName2 = "text.txt";
            string fileName3 = "result.txt";
            List<string> words = ReadWords(fileName1);
            var occurrences = CalculateOcurances(fileName2, words);
            WriteOccurrences(fileName3, occurrences);
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

        static Dictionary<string, int> CalculateOcurances(string fileName, List<string> words)
        {
            try
            {
                var reader = new StreamReader(fileName);
                string? line;
                var occurrences = new Dictionary<string, int>();

                while ((line = reader.ReadLine()) != null)
                {
                    var lineSplit = line.Split(" ", StringSplitOptions.RemoveEmptyEntries);
                    foreach (var word in words)
                    {
                        if (line.Contains(word))
                        {
                            if (occurrences.ContainsKey(word))
                            {
                                var count = lineSplit.Select(a => a).Where(a => a.Contains(word)).Count();
                                occurrences[word] += count;
                            }

                            else
                            {
                                var count = lineSplit.Select(a => a).Where(a => a.Contains(word)).Count();
                                occurrences.Add(word, count);
                            }

                        }

                    }
                }

                occurrences = occurrences.OrderByDescending(x => x.Value).ToDictionary(x => x.Key, x => x.Value);
                reader.Close();
                return occurrences;
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

        static void WriteOccurrences(string fileName, Dictionary<string, int> occurrences)
        {
            try
            {
                using var writer = new StreamWriter(fileName);
                foreach (var word in occurrences.Keys)
                {
                    string line = $"Word {word}: {occurrences[word]}";
                    writer.WriteLine(line);
                }
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