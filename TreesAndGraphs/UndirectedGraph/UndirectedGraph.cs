using System;
using System.Collections.Generic;

namespace Program
{
    public class UndirectedGraph
    {
        // number of vertices
        private int nbVertices;

        // number of edges
        private int nbEdges = 0;


        private List<int>[] adj;


        public UndirectedGraph(int v)
        {
            this.nbVertices = v;
            this.adj = new List<int>[v];
            for (int i = 0; i < adj.Length; i++)
            {
                // Assing an empty list of adjacents for each vertex
                this.adj[i] = new List<int>();
            }
        }

        public UndirectedGraph(List<int>[] adj)
        {
            this.adj = adj;
        }

        public int V { get; }

        public int E { get; private set; }

        public void AddEdge(int u, int v)
        {
            if (v < 0 || v > this.adj.Length)
            {
                throw new ArgumentOutOfRangeException($"Error, the value provided for 'v' should be between 0 and {this.adj.Length - 1} \n\n Actual v = {v}\n");
            }

            if (u < 0 || u > this.adj.Length)
            {
                throw new ArgumentOutOfRangeException($"Error, the value provided for 'v' should be  between 0 and {this.adj.Length - 1} \n\n Actual v = {v}\n");
            }

            adj[u].Add(v);
            adj[v].Add(u);
        }

        public void RemoveEdge(int u, int v)
        {
            adj[u].Remove(v);
            adj[v].Remove(u);
        }

        public bool HasEdge(int u, int v)
        {
            bool hasEdge = adj[u].Contains(v) && adj[v].Contains(u);
            return hasEdge;
        }

        public IList<int> GetSuccessors(int v)
        {
            return adj[v];
        }

        //public void BFS(int x, int y)
        //{
        //    bool isEqual = false;
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
        //        List<int> list = adj[x];

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
        static void Main() { }
        public void DFS(int src, bool[] visited)
        {
            visited[src] = true;
            Console.Write(src + "->");
            if (adj[src] != null)
            {
                foreach (var item in adj[src])
                {
                    if (!visited[item] == true)
                    {
                        DFS(item, visited);
                    }
                }
            }
        }

        public void Traverse()
        {
            bool[] visited = new bool[adj.Length];
            DFS(0,visited);
        }
    }
}