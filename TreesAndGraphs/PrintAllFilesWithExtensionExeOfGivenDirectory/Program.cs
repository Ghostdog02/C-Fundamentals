using System.Xml.Linq;

namespace PrintAllFilesWithExtensionExeOfGivenDirectory
{
    public class Program
    {
        static void DFS(DirectoryInfo currDir, FileInfo file, string spaces)
        {
            if (file == null)
                Console.WriteLine(currDir);
            else
                Console.WriteLine(spaces + file);
            DirectoryInfo[] children = currDir.GetDirectories();
            foreach (var item in children)
            {
                EnumerationOptions options = new();
                options.IgnoreInaccessible = true;
                foreach (var element in item.GetFiles("*.exe", options))
                {
                    DFS(item, element, spaces + "   ");
                }
            }
        }

        static void Main(string[] args)
        {
            var dir = new DirectoryInfo("C:\\Windows\\");
            DFS(dir, null, string.Empty);
        }
    }
}