namespace Program
{
    public class Program
    {
        static void Main()
        {
            Tree tree =
new Tree(7,
    new Tree(4,
        new Tree(4),
        new Tree(4),
        new Tree(5)),
    new Tree(1),
    new Tree(14,
        new Tree(23),
        new Tree(6))
);
            tree.TraverseDFS(14);
            Console.WriteLine(tree.GetOccurrences());
        }
    }
}