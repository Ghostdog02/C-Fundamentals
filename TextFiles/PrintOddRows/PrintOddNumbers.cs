namespace Program
{
    public class PrintOddRows
    {
        static void PrintLine()
        {
            string fileName = "Example.txt";
            try
            {
                using StreamReader reader = new(fileName);
                string? line;
                int count = 1;
                
                while ((line = reader.ReadLine()) != null)
                {
                    if (count % 2 != 0)
                    {
                        Console.WriteLine(line);
                    }
                    count++;
                }
            }

            catch (FileNotFoundException)
            {
                throw new FileNotFoundException($"The file {fileName} wasn't found");
            }

            catch (IOException)
            {

                throw new IOException($"The file {fileName} can't be open.");
            }

        }

        static void Main()
        {
            PrintLine();
        }

    }
}