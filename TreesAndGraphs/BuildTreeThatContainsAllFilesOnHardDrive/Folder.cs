namespace Program
{
    public record Folder
    {
        public string FullName { get; }

        public string Name { get; }

        public List<File> Files { get; } = new();

        public List<Folder> ChildFolders { get; } = new();

        private bool hasParent;

        public Folder(string name, string fullName)
        {
            this.Name = name;
            this.FullName = fullName;
        }
                
        public Folder GetChild(int index)
        {
            return this.ChildFolders[index];
        }       
    }
}
