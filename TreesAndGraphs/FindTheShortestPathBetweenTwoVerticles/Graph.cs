using System;
using System.Collections.Generic;

namespace Program
{
    public class Graph
    {
        private List<int>[] adjacent;

        public Graph(int size)
        {
            this.adjacent = new List<int>[size];
            for (int i = 0; i < size; i++)
            {
                // Assing an empty list of adjacents for each vertex
                this.adjacent[i] = new List<int>();
            }
        }

        public Graph(List<int>[] childNodes)
        {
            this.adjacent = childNodes;
        }

        public int Size
        {
            get { return this.adjacent.Length; }
        }

        public void AddEdge(int u, int v)
        {
            adjacent[u].Add(v);
        }

        public void RemoveEdge(int u, int v)
        {
            adjacent[u].Remove(v);
        }

        public bool HasEdge(int u, int v)
        {
            bool hasEdge = adjacent[u].Contains(v);
            return hasEdge;
        }

        public IList<int> GetSuccessors(int v)
        {
            return adjacent[v];
        }

        public void PrintShotestDistance(int src, int dest)
        {
            int[] pred;
            int[] dist;

            if (BFS(src, dest, out pred, out dist) == false)
            {
                Console.WriteLine("Given source and destination are not connected");
                return;
            }

            List<int> path = new List<int>();
            int crawl = dest;
            path.Add(crawl);
            while (pred[crawl] != -1)
            {
                path.Add(pred[crawl]);
                crawl = pred[crawl];
            }

            // Print distance
            Console.WriteLine("Shortest path length is: " +
                               dist[dest]);

            // Print path
            Console.WriteLine("Path is ::");

            for (int i = path.Count - 1;
                     i >= 0; i--)
            {
                Console.Write(path[i] + " ");
            }
        }

        private bool BFS(int src, int dest, out int[] pred, out int[] dist)
        {
            List<int> queue = new List<int>();
            pred = new int[Size];
            dist = new int[Size];
            bool isEqual = false;
            bool[] visited = new bool[Size];
            for (int i = 0; i < Size; i++)
            {
                visited[i] = false;
                dist[i] = int.MaxValue;
                pred[i] = -1;

            }

            visited[src] = true;
            dist[src] = 0;
            queue.Add(src);

            while (queue.Any())
            {
                int u = queue[0];
                queue.RemoveAt(0);
                List<int> list = adjacent[u];

                foreach (var val in list)
                {
                    if (!visited[val])
                    {
                        visited[val] = true;
                        dist[val] = dist[u] + 1;
                        pred[val] = u;
                        queue.Add(val);

                        if (val == dest)
                            return true;
                    }
                }
            }

            return false;
        }

        //public void PrintPath()
        //{
        //    foreach (var element in path)
        //    {
        //        Console.WriteLine(element);
        //    }
        //}

    }
}