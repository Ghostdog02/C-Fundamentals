using System;
using System.IO;

namespace ReadinfBinaryFile
{
    public class Program
    {
        public static void Main()
        {
            string binaryFile = "C:\\temp\\input.docx";
            var bytes = ReadBinary(binaryFile);
            WriteBinary("C:\\temp\\output.docx", bytes);
        }

        public static byte[] ReadBinary(string fileName)
        {
            using FileStream stream = new FileStream(fileName, FileMode.Open, FileAccess.Read);
            using MemoryStream memoryStream = new MemoryStream();

            byte[] buffer = new byte[16 * 1024];

            int read = 0;
            while ((read = stream.Read(buffer, 0, buffer.Length)) > 0)
            {
                memoryStream.Write(buffer, 0, read);
            }

            return memoryStream.ToArray();
        }

        public static void WriteBinary(string fileName, byte[] input)
        {
            using FileStream file = new FileStream(fileName, FileMode.OpenOrCreate, FileAccess.Write);
            while (true)
                file.Write(input, 0, input.Length);
        }
    }
}
