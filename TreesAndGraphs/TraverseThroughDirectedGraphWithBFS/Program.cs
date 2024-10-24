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
            g.AddEdge(2, 3);
            g.AddEdge(3, 3);
            g.BFS(0, 2);
        }
    }
}