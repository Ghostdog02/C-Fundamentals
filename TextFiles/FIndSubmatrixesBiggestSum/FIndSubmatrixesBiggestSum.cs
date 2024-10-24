namespace Program
{
    public class FIndSubmatrixesBiggestSum
    {
        static void Main()
        {
            var fileName = "Matrix.txt";
            var matrix = ConvertTextFileToMatrix(fileName);
            FindBiggestSum(matrix);
        }

        static int[,] ConvertTextFileToMatrix(string fileName)
        {
            using var reader = new StreamReader(fileName);
            var size = Int32.Parse(reader.ReadLine());
            string? line;
            int[,] matrix = new int[size, size];
            int countRows = 0;
            while ((line = reader.ReadLine()) != null)
            {
                line = line.Replace(" ", "");
                for (int index = 0; index < line.Length; index++)
                {
                    matrix[countRows, index] = int.Parse(line[index].ToString());
                }
                countRows++;
            }

            return matrix;
        }

        static void FindBiggestSum(int[,] matrix)
        {
            string fileNameForSum = "Sum.txt";
            List<int> sums = new List<int>();
            for (int row = 0; row < matrix.GetLength(0) - 1; row++)
            {
                for (int column = 0; column < matrix.GetLength(1) - 1; column++)
                {
                    sums.Add(matrix[row, column] + matrix[row, column + 1] + matrix[row + 1, column] + matrix[row + 1, column + 1]);
                }
            }

            sums = sums.OrderByDescending(a => a).ToList();
            File.Create(fileNameForSum).Dispose();
            using var writer = new StreamWriter(fileNameForSum);
            writer.WriteLine($"{sums[0]}");
        }
    }
}