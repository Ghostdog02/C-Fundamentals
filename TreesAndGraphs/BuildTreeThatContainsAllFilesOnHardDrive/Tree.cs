namespace Program
{
    public class Tree
    {
        private static EnumerationOptions Options = new EnumerationOptions() { IgnoreInaccessible = true };

        public void GetDirectories(DirectoryInfo dir, Folder folder)
        {
            if (dir == null)
            {
                return;
            }

            var files = dir.GetFiles("*", Options);
            folder.Files.AddRange(files.ToFileCollection());

            var directories = dir.GetDirectories("*", Options);
            foreach (var item in directories)
            {
                var currentFolder = new Folder(item.Name, item.FullName);
                folder.ChildFolders.Add(currentFolder);
                GetDirectories(item, currentFolder);
            }
        }

       

    }
}
