namespace Program
{
    //public class File
    //{
    //    public string Name { get; set; }

    //    public long Size { get; set; }

    //    public File(string name, long size)
    //    {
    //        this.Name = name;
    //        this.Size = size;
    //    }

    //    //TO DO: Add method
    //}

    public record File(string Name, long Size);
}