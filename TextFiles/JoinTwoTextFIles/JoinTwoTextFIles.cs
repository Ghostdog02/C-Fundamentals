namespace Program
{
    public class JoinTwoTextFIles
    {
        static void JoinFiles()
        {
            string fileName1 = "Example1.txt";
            string fileName2 = "Example2.txt";
            string fileName3 = "JoinnedExample.txt";
            string line1;
            string line2;
            using var reader1 = new StreamReader(fileName1);
            using var reader2 = new StreamReader(fileName2);
            var writer1 = new StreamWriter(fileName3, false);
            while((line1 = reader1.ReadLine()) != null)
            {
                writer1.WriteLine(line1);
            }

            writer1.Dispose();
            using var writer2 = new StreamWriter(fileName3, true);
            while ((line2 = reader2.ReadLine()) != null)
            {
                writer2.WriteLine(line2);
            }
        }

        static void Main()
        {
            JoinFiles();
        }
    }
}