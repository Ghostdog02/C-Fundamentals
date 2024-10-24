namespace CountAppearancesOfWordsInTextFile
{
    public class Program
    {
        static void Main(string[] args)
        {
            var path = @"D:\Documents\words.txt";
            var reader = new StreamReader(path);
            string line;
            var seperators = new string[] { ".", " ", "?", "-", ",", "!" };
            var occurrences = new Dictionary<string, int>();
            while ((line = reader.ReadLine()) != null)
            {
                var words = line.Split(seperators, StringSplitOptions.RemoveEmptyEntries);
                foreach (var word in words)
                {
                    if (occurrences.ContainsKey(word.ToLower())) { occurrences[word.ToLower()]++; }

                    else { occurrences[word.ToLower()] = 1; }
                }
            }

            var appearances = new List<int>();
            occurrences = occurrences.OrderBy(x => x.Value).ToDictionary(x => x.Key, x => x.Value);
            //appearances.AddRange(occurrences.Values.OrderBy(a => a));
            //occurrences = (Dictionary<string,int>)occurrences.OrderBy(a => a.Value);
            foreach (var key in occurrences.Keys)
            {
                Console.WriteLine($"Word {key}: {occurrences[key]}");
            }
        }
    }
}