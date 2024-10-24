namespace Program
{
    public static class Extensions
    {
        public static IEnumerable<File> ToFileCollection(this FileInfo[] files)
            => files.Select(a => new File(a.Name, a.Length));
    }
}
