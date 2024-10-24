namespace Program
{
    public class Program
    {
        static void Main(string[] args)
        {
            //UndirectedGraph myGraph = new UndirectedGraph(7);
            //myGraph.AddEdge(0, 1);
            //myGraph.AddEdge(0, 2);
            //myGraph.AddEdge(2, 3);
            //myGraph.AddEdge(2, 4);
            //myGraph.AddEdge(2, 5);
            //myGraph.AddEdge(5, 6);
            //myGraph.Traverse();

            var mygraph = new UndirectedGraph(9);
            mygraph.AddEdge(0, 1);
            mygraph.AddEdge(1, 6);
            mygraph.AddEdge(1, 5);
            mygraph.AddEdge(1, 7);
            mygraph.AddEdge(0, 2);
            mygraph.AddEdge(2, 8);
            mygraph.AddEdge(0, 3);
            mygraph.AddEdge(0, 4);
            mygraph.Traverse();
        }
    }
}