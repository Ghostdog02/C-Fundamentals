namespace FindLoops
{
    public class Program
    {
        static void Main(string[] args)
        {
            Graph graph = new(5);
            graph.AddEdge(1, 2);
            graph.AddEdge(2, 3);
            graph.AddEdge(3, 1);
            graph.AddEdge(3, 4);
            graph.AddEdge(4, 4);
            graph.PrintCycles();
        }

    }
}