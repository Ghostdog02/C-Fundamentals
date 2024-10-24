using System;
using System.IO;
using System.Text;

namespace ReadingBinaryFile
{
    public class Program
    {
        static void Main()
        {
            //var fileName = Console.ReadLine();
            var fileName = "D:\\Documents\\Intro-CSharp-Book-v2015.pdf";
            var byteData = ReadFile(fileName);

            var destinationFile = "D:\\Documents\\Intro-CSharp-Book-v2015-2.pdf";
            WriteFile(byteData, destinationFile);
        }

        private static void WriteFile(byte[] byteData, string destinationFile)
        {
            using MemoryStream memoryStream = new MemoryStream(byteData);
            using FileStream stream = new FileStream(destinationFile, FileMode.Create);

            const int MAX_BUFFER = 1048576;
            var buffer = new byte[MAX_BUFFER];

            int counter = 0;
            while ((counter = memoryStream.Read(buffer, 0, MAX_BUFFER)) != 0)
            {
                stream.Write(buffer, 0, counter);
            }
        }

        private static byte[] ReadFile(string fileName)
        {
            //using FileStream stream = new FileStream(fileName, FileMode.Open);
            //using MemoryStream memoryStream = new MemoryStream();
            ////var bytes = Encoding.UTF8.GetBytes(fileName);
            ////MemoryStream memoryStream = new MemoryStream();
            ////var lenght = fileName.Length;
            //var bytes = new byte[lenght];
            //while (stream.Read(bytes, 0, bytes.Length) != 0)
            //{
            //    //memoryStream.stream.Read(bytes, 0, lenght);
            //    var line = ((byte)stream.Read(bytes, 0, bytes.Length));
            //    memoryStream.WriteByte(line);

            //}
            //return memoryStream.ToArray();

            const int MAX_BUFFER = 1048576; 
            var buffer = new byte[MAX_BUFFER];

            using FileStream stream = new FileStream(fileName, FileMode.Open);
            using MemoryStream memoryStream = new MemoryStream();

            int counter = 0;
            while ((counter = stream.Read(buffer, 0, MAX_BUFFER)) != 0)
            {
                memoryStream.Write(buffer, 0, counter);
            }

            return memoryStream.ToArray();
        }
    }
}
