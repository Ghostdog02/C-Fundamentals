namespace Program
{
    public class Program
    {
        static void Main(string[] args)
        {
            Graph g = new Graph(5);
            g.AddEdge(0, 1);
            g.AddEdge(0, 2);
            g.AddEdge(1, 2);
            g.AddEdge(2, 0);
            g.AddEdge(2, 3);
            g.AddEdge(3, 3);
            g.AddEdge(3, 4);
            g.AddEdge(0, 4);
            g.PrintShotestDistance(0, 4);
        }
    }
}