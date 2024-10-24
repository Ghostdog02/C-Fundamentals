using System;
using System.Collections.Generic;

namespace Program
{
    public class Graph
    {
        private int[][] adj;
        private int size;

        public int[][] Adj { get => adj; }
        public Graph(int size)
        {
            this.size = size;
            adj = new int[size][];
            for (int i = 0; i < size; i++)
            {
                adj[i] = new int[size];
                for (int j = 0; j < size; j++)
                {
                    adj[i][j] = int.MaxValue;
                }
            }
        }

        //public Graph(List<int>[] childNodes)
        //{
        //    this.childNodes = childNodes;
        //}

        public int Size { get => size; }

        public void AddEdge(int u, int v, int weight)
        {
            adj[u][v] = weight;
        }

        public int MinDistance(int[] dist, bool[] sptSet)
        {
            // Initialize min value
            int min = int.MaxValue, min_index = -1;

            for (int v = 0; v < Size; v++)
                if (sptSet[v] == false && dist[v] <= min)
                {
                    min = dist[v];
                    min_index = v;
                }

            return min_index;
        }

        public void DijkstraAlgorithm(int src, int[] path)
        {
            int[] dist
                = new int[Size]; // The output array. dist[i]
                                 // will hold the shortest
                                 // distance from src to i

            // sptSet[i] will true if vertex
            // i is included in shortest path
            // tree or shortest distance from
            // src to i is finalized
            bool[] sptSet = new bool[Size];

            // Initialize all distances as
            // INFINITE and stpSet[] as false
            for (int i = 0; i < Size; i++)
            {
                dist[i] = int.MaxValue;
                sptSet[i] = false;
                path[i] = -1;
            }

            // Distance of source vertex
            // from itself is always 0
            dist[src] = 0;

            // Find shortest path for all vertices
            for (int count = 0; count < Size - 1; count++)
            {
                // Pick the minimum distance vertex
                // from the set of vertices not yet
                // processed. u is always equal to
                // src in first iteration.
                int u = MinDistance(dist, sptSet);

                // Mark the picked vertex as processed
                sptSet[u] = true;

                // Update dist value of the adjacent
                // vertices of the picked vertex.
                for (int v = 0; v < Size; v++)
                {
                    // Update dist[v] only if is not in
                    // sptSet, there is an edge from u
                    // to v, and total weight of path
                    // from src to v through u is smaller
                    // than current value of dist[v]
                    if (!sptSet[v] && (adj[u][v] != 0)
                        && (dist[u] != int.MaxValue)
                        && ((dist[u] + adj[u][v]) < dist[v]))
                    {
                        dist[v] = dist[u] + adj[u][v];
                        path[v] = u;
                    }

                }

            }
        }

        public void PrintPath(int[] path, int source)
        {
            Console.WriteLine($"Path: 0");
            for (int i = 1; i < Size; i++)
            {
                var index = i;
                Console.Write($"Path: ");
                while (path[index] != source)
                {
                    if (path[index] != -1)
                    {
                        var vertex = path[index];
                        Console.Write($"{vertex} ");
                        index = vertex;
                    }
                }
                Console.Write(index);
                Console.Write(" ");
                Console.Write(source);
                Console.WriteLine();
            }
        }

        //public void RemoveEdge(int u, int v)
        //{
        //    childNodes[u].Remove(v);
        //}

        //public bool HasEdge(int u, int v)
        //{
        //    bool hasEdge = childNodes[u].Contains(v);
        //    return hasEdge;
        //}

        //public IList<int> GetSuccessors(int v)
        //{
        //    return childNodes[v];
        //}

        //public void BFS(int x, int y)
        //{
        //    bool[] visited = new bool[Size];
        //    for (int i = 0; i < Size; i++)
        //        visited[i] = false;

        //    Queue<int> queue = new Queue<int>();
        //    visited[x] = true;
        //    queue.Enqueue(x);

        //    while (queue.Any())
        //    {
        //        x = queue.Dequeue();
        //        Console.Write(x + " ");
        //        List<int> list = childNodes[x];

        //        foreach (var val in list)
        //        {
        //            if (!visited[val])
        //            {
        //                visited[val] = true;
        //                queue.Enqueue(val);
        //            }
        //        }
        //    }
        //}

        //public void DFS(int src, bool[] visited)
        //{
        //    visited[src] = true;
        //    Console.Write(src + "->");
        //    if (childNodes[src] != null)
        //    {
        //        foreach (var item in childNodes[src])
        //        {
        //            if (!visited[item] == true)
        //            {
        //                DFS(item, visited);
        //            }
        //        }
        //    }
        //}

    }
}