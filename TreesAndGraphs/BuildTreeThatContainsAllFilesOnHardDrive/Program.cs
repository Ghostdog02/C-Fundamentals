namespace Program
{
    public class Program
    {
        private long Size { get; set; }

        static void Main(string[] args)
        {
            var path = @"D:\Games\";
            var root = new Folder("temp", path);
            Traverse(path, root);
            PrintDFS(root, string.Empty);
            long size = 0;
            CalculateSumOfFileSizes(root, out size);
            Console.WriteLine(size);
            //Console.ReadKey();
        }

        private static EnumerationOptions Options = new EnumerationOptions() { IgnoreInaccessible = true };

        private static void Traverse(string path, Folder folder)
        {
            var directory = new DirectoryInfo(path);

            // Get files
            var files = directory.GetFiles("*", Options);
            folder.Files.AddRange(files.ToFileCollection());

            // Traverse folders
            var directories = directory.GetDirectories("*", Options);
            foreach (var dirInfo in directories)
            {
                var currentFolder = new Folder(dirInfo.Name, dirInfo.FullName);
                folder.ChildFolders.Add(currentFolder);
                Traverse(dirInfo.FullName, currentFolder);
            }
        }

        private static void PrintDFS(Folder folder, string spaces)
        {
            if (folder == null)
            {
                return;
            }

            Console.WriteLine($"{spaces}{folder.FullName}");

            for (int i = 0; i < folder.ChildFolders.Count; i++)
            {
                var childFolder = folder.GetChild(i);
                PrintDFS(childFolder, spaces + "   ");
            }
        }

        private static void CalculateSumOfFileSizes(Folder folder, out long size)
        {
            size = 0;
            Queue<Folder> visitedDirsQueue =
               new Queue<Folder>();
            visitedDirsQueue.Enqueue(folder);
            while (visitedDirsQueue.Count > 0)
            {
                var currentFolder = visitedDirsQueue.Dequeue();
                var files = currentFolder.Files;
                foreach (var file in files)
                {
                    size += file.Size;
                }
                var children = currentFolder.ChildFolders;
                foreach (var child in children)
                {
                    visitedDirsQueue.Enqueue(child);
                }
            }
        }


    }
}
