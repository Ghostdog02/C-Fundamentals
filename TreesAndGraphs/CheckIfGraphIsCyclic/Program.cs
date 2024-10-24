namespace Program
{
    public class Program
    {
        static void Main(string[] args)
        {
            //UndirectedGraph g = new(4);
            //g.AddEdge(0, 1);
            //g.AddEdge(0, 2);
            //g.AddEdge(1, 2);
            //g.AddEdge(2, 0);
            //g.AddEdge(2, 3);
            //g.AddEdge(3, 3);
            //g.PrintLoop();
            //UndirectedGraph g = new(11);
            //g.AddEdge(1, 2);
            //g.AddEdge(2, 3);
            //g.AddEdge(3, 4);
            //g.AddEdge(4, 5);
            //g.AddEdge(5, 6);
            //g.AddEdge(6, 7);
            //g.AddEdge(7, 8);
            //g.AddEdge(8,3);
            //g.PrintLoop();
            //UndirectedGraph g = new(6);
            //g.AddEdge(1, 2);
            //g.AddEdge(2, 3);
            //g.AddEdge(3, 4);
            //g.AddEdge(4, 5);
            //g.AddEdge(5,1);
            //g.PrintLoop();
            UndirectedGraph g1 = new UndirectedGraph(5);
            g1.AddEdge(1, 0);
            g1.AddEdge(0, 2);
            g1.AddEdge(2, 1);
            g1.AddEdge(0, 3);
            g1.AddEdge(3, 4);
            g1.FindCycle();
        }
    }
}