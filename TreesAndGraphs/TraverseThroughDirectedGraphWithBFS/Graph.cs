using System;
using System.Collections.Generic;

namespace Program
{
    public class Graph
    {
        private List<int>[] childNodes;

        public Graph(int size)
        {
            this.childNodes = new List<int>[size];
            for (int i = 0; i < size; i++)
            {
                // Assing an empty list of adjacents for each vertex
                this.childNodes[i] = new List<int>();
            }
        }

        public Graph(List<int>[] childNodes)
        {
            this.childNodes = childNodes;
        }

        public int Size
        {
            get { return this.childNodes.Length; }
        }

        public void AddEdge(int u, int v)
        {
            childNodes[u].Add(v);
        }

        public void RemoveEdge(int u, int v)
        {
            childNodes[u].Remove(v);
        }

        public bool HasEdge(int u, int v)
        {
            bool hasEdge = childNodes[u].Contains(v);
            return hasEdge;
        }

        public IList<int> GetSuccessors(int v)
        {
            return childNodes[v];
        }

        public void BFS(int x, int y)
        {
            bool[] visited = new bool[Size];
            for (int i = 0; i < Size; i++)
                visited[i] = false;

            Queue<int> queue = new Queue<int>();
            visited[x] = true;
            queue.Enqueue(x);

            while (queue.Any())
            {
                x = queue.Dequeue();
                Console.Write(x + " ");
                List<int> list = childNodes[x];

                foreach (var val in list)
                {
                    if (!visited[val])
                    {
                        visited[val] = true;
                        queue.Enqueue(val);
                    }
                }
            }
        }

        public void DFS(int src, bool[] visited)
        {
            visited[src] = true;
            Console.Write(src + "->");
            if (childNodes[src] != null)
            {
                foreach (var item in childNodes[src])
                {
                    if (!visited[item] == true)
                    {
                        DFS(item, visited);
                    }
                }
            }
        }

    }
}