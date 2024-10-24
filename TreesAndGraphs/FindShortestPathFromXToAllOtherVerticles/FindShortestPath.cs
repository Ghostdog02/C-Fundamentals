using Program;

namespace FindShortestPathFromXToAllOtherVerticles
{
    public class FindShortestPath
    {
        static void Main(string[] args)
        {
            var graph = new Graph(8);
            graph.AddEdge(0, 1, 8);
            graph.AddEdge(1, 2, 11);
            graph.AddEdge(2, 3, 5);
            graph.AddEdge(0, 5, 14);
            graph.AddEdge(5, 1, 17);
            graph.AddEdge(5, 6, 13);
            graph.AddEdge(6, 4, 9);
            graph.AddEdge(4, 3, 7);
            graph.AddEdge(5, 2, 6);
            graph.AddEdge(6, 3, 4);
            int[] path = new int[graph.Size];
            int[] spt = new int[graph.Size];
            graph.DijkstraAlgorithm(0, path);

            graph.PrintPath(path,0);
        }

        

        //static int[] DijkstraAlgorithm(Graph graph, int source, int[] path)
        //{
        //    int count = graph.Size;
        //    int[] dist = new int[count];
        //    bool[] visited = new bool[count];

        //    for (int i = 0; i < count; i++)
        //    {
        //        visited[i] = false;
        //        path[i] = -1;
        //        dist[i] = int.MaxValue;
        //    }

        //    int current = source;
        //    dist[source] = 0;
        //    path[source] = -1;
        //    var sett = new HashSet<int>();

        //    while (true)
        //    {

        //        // Mark current as visited
        //        visited[current] = true;
        //        //var currVertex = graph.GetVertex(current);
        //        var currentVertex = graph.Vertices[current];
        //        for (int i = 0; i < currentVertex.NeighborsCount; i++)
        //        {
        //            int v = currentVertex.Neighbors[i].Value;
        //            if (visited[v])
        //                continue;

        //            // Inserting into the
        //            // visited vertex
        //            sett.Add(v);
        //            int alt = dist[current] + currentVertex.Neighbors[i].Distance;

        //            // Condition to check the distance
        //            // is correct and update it
        //            // if it is minimum from the previous
        //            // computed distance
        //            if (alt < dist[v])
        //            {
        //                dist[v] = alt;
        //                path[v] = current;
        //            }
        //        }

        //        sett.Remove(current);

        //        if (sett.Count == 0)
        //            break;

        //        // The new current
        //        int minDist = int.MaxValue;
        //        int index = 0;

        //        // Loop to update the distance
        //        // of the vertices of the graph
        //        foreach (int a in sett)
        //        {
        //            if (dist[a] < minDist)
        //            {
        //                minDist = dist[a];
        //                index = a;
        //            }
        //        }

        //        current = index;
        //    }

        //    return dist;
        //}

        //static void PrintPath(int[] path, int i, int s)
        //{
        //    if (i != s)
        //    {

        //        // Condition to check if
        //        // there is no path between
        //        // the vertices
        //        if (path[i] == -1)
        //        {
        //            Console.WriteLine("Path not found!!");
        //            return;
        //        }

        //        PrintPath(path, path[i], s);
        //        Console.WriteLine(path[i] + " ");
        //    }
        //}
    }
}