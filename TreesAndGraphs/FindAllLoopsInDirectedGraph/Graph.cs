using System.Collections.Generic;

namespace FindLoops
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

        // Function to check if cycle exists
        private bool isCyclicUtil(int i, bool[] visited,
                                  bool[] recStack, List<int> path,
                                  int[] pred)
        {
            // Mark the current node as visited and
            // part of recursion stack
            if (recStack[i])
            {
                return true;
            }

            if (visited[i])
                return false;

            visited[i] = true;

            recStack[i] = true;
            List<int> children = childNodes[i];

            foreach (int child in children)
            {
                if (!visited[child])
                {
                    pred[child] = i;
                }

                else if (visited[child] && (i == child))
                {
                    path.Add(child);
                    path.Add(child);
                }

                else
                {
                    path.Add(child);
                    path.Add(i);
                }

                if (isCyclicUtil(child, visited, recStack, path, pred))
                    return true;
            }

            recStack[i] = false;

            return false;
        }

        static bool Contains(List<int> path, List<List<int>> cycles)
        {
            if (cycles == null) throw new ArgumentNullException(nameof(cycles));
            var cycleCount = cycles.Count;
            for (int i = 0; i < cycleCount; i++)
            {
                //Remove last item because its the same as first
                var currentPathSorted = cycles[i].OrderBy(a => a).Distinct().ToList();
                var pathSorted = path.OrderBy(a => a).Distinct().ToList();
                if (Equals(pathSorted, currentPathSorted))
                {
                    return true;
                }

            }

            return false;
        }

        static bool Equals(List<int> path, List<int> currentPath)
        {
            if ((path is null) || (currentPath is null)) return false;

            if (path.Count != currentPath.Count) return false;

            for (int i = 0; i < path.Count; i++)
            {
                if (path[i] != currentPath[i])
                {
                    return false;
                }
            }

            return true;
        }

        private void FindCycles(List<List<int>> cycles)
        {
            // Mark all the vertices as not visited and
            // not part of recursion stack

            // Call the recursive helper function to
            // detect cycle in different DFS trees
            for (int i = 0; i < Size; i++)
            {
                bool[] visited = new bool[Size];
                bool[] recStack = new bool[Size];
                List<int> path = new List<int>(Size);
                int[] pred = new int[Size];
                for (int f = 0; f < Size; f++)
                {
                    pred[f] = -1;
                }

                if (isCyclicUtil(i, visited, recStack, path, pred))
                {
                    if ((path[0] == path[1]) && !cycles.Contains(path))
                    {
                        cycles.Add(path);
                    }

                    else
                    {
                        var crawl = path.Last();
                        while ((pred[crawl] != -1) && (pred[crawl] != path.First()))
                        {
                            path.Add(pred[crawl]);
                            crawl = path.Last();
                        }

                        path.Add(path.First());
                        path.Reverse();
                        if (!Contains(path, cycles))
                        {
                            cycles.Add(path);
                        }
                    }
                }
            }
        }

        public void PrintCycles()
        {
            var cycles = new List<List<int>>();
            FindCycles(cycles);
            if (cycles.Count == 0)
            {
                Console.WriteLine($"There are no cycles");
            }

            else
            {
                for (int i = 0; i < cycles.Count; i++)
                {
                    Console.WriteLine($"Cycle {i + 1}");
                    for (int j = 0; j < cycles[i].Count; j++)
                    {
                        Console.WriteLine(cycles[i][j]);
                    }
                }
            }
        }

    }
}