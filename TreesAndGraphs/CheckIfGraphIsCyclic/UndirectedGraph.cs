namespace Program
{
    public class UndirectedGraph
    {
        private List<int>[] childNodes;

        public UndirectedGraph(int size)
        {
            this.childNodes = new List<int>[size];
            for (int i = 0; i < size; i++)
            {
                // Assing an empty list of adjacents for each vertex
                this.childNodes[i] = new List<int>();
            }
        }

        public UndirectedGraph(List<int>[] childNodes)
        {
            this.childNodes = childNodes;
        }

        public int Size
        {
            get { return this.childNodes.Length; }
        }

        public void AddEdge(int u, int v)
        {
            childNodes[v].Add(u);
            childNodes[u].Add(v);
        }

        public void RemoveEdge(int u, int v)
        {
            childNodes[u].Remove(v);
            childNodes[v].Remove(u);
        }

        public bool HasEdge(int u, int v)
        {
            return childNodes[u].Contains(v) && childNodes[v].Contains(u);
        }

        public IList<int> GetSuccessors(int v)
        {
            return childNodes[v];
        }

        //private void BFS(int x, int y)
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

        private bool isCyclicUtil(int src, bool[] visited, int[] pred, int parent, List<int> path)
        {
            //path.Add(src);
            visited[src] = true;
            //Console.Write(src + "->");
            if (childNodes[src] != null)
            {
                foreach (var item in childNodes[src])
                {
                    if (!visited[item])
                    {
                        pred[item] = src;
                        if (isCyclicUtil(item, visited, pred, src, path))
                            return true;
                    }

                    else if (item != parent)
                    {
                        //if (pred[item] == -1)
                        //    pred[item] = src;
                        path.Add(item);
                        path.Add(src);
                        return true;
                    }
                }
            }

            return false;
        }

        private bool isCyclic(List<int> path, int[] pred)
        {
            bool[] visited = new bool[Size];
            for (int i = 0; i < Size; i++)
            {
                visited[i] = false;
                pred[i] = -1;
            }

            for (int i = 0; i < Size; i++)
            {
                if (!visited[i])
                    if (isCyclicUtil(i, visited, pred, -1, path))
                    {
                        //this.path = path;
                        //this.pred = pred.ToList();
                        return true;
                    }


            }

            return false;
        }

        public void FindCycle()
        {
            List<int> path = new List<int>(Size);
            int[] pred = new int[Size];
            
            if (isCyclic(path, pred))
            {
                var crawl = path.Last();
                while ((pred[crawl] != -1) && (pred[crawl] != path.First()))
                {
                    path.Add(pred[crawl]);
                    crawl = path.Last();
                }
                path.Add(path.First());

                path.Reverse();
                foreach (var element in path)
                {
                    Console.WriteLine(element);
                }
            }

            else
            {
                Console.WriteLine($"There is no loop");
            }
        }

    }
}