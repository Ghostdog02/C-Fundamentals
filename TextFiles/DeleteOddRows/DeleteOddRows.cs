namespace Program
{
    public class DeleteOddRows
    {
        static void Main()
        {
            string fileName = "Example.txt";
            string fileNameTemp = "ExampleTemp.txt";
            WriteOddRows(fileName, fileNameTemp);
            CopyTextFile(fileName, fileNameTemp);
        }

        static void WriteOddRows(string fileName, string fileNameTemp)
        {
            File.Create(fileNameTemp).Close();
            var reader = new StreamReader(fileName);
            var writer = new StreamWriter(fileNameTemp);
            string? line;
            int count = 1;
            while ((line = reader.ReadLine()) != null)
            {
                if (count % 2 != 0)
                    writer.WriteLine(line);
                count++;
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