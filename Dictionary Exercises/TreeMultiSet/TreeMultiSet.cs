using System.Collections;

namespace TreeMultiSetImplementation
{
    public class TreeMultiSet<T> : IEnumerable<KeyValuePair<T, List<T>>>, IComparer<T>
        where T : notnull
    {
        private SortedDictionary<T, List<T>> set = new SortedDictionary<T, List<T>>();

        public int Count { get; private set; } = 0;

        public void Add(T item)
        {
            if (set.ContainsKey(item))
            {
                set[item].Add(item);
                Count++;
            }

            else
            {
                set.Add(item, new List<T>());
                Count++;
            }
        }

        public int FindOccurrences(T item)
        {
            //Add 1 beacause the key itself is one occurrence 
            return set[item].Count() + 1;
        }

        public IEnumerator<KeyValuePair<T, List<T>>> GetEnumerator() => set.GetEnumerator();

        public void Remove(T item)
        {
            if (set.ContainsKey(item))
            {
                Count--;
                foreach (var element in set[item])
                {
                    Count--;
                }

                set.Remove(item);

            }
        }

        //Removes by given pair one sequence and not the whole key value pair
        public void RemoveElement(KeyValuePair<T, List<T>> item)
        {
            if (set.Contains(item))
            {
                if (set[item.Key].Count > 0)
                {
                    item.Value.RemoveAt(0);
                    Count--;
                }

                else
                {
                    set.Remove(item.Key);
                    Count--;
                }

            }
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            foreach (KeyValuePair<T, List<T>> pair in set)
            {
                yield return pair;
            }
        }

        public T FindMax()
        {
            return set.Last().Key;
        }

        public T FindMin()
        {
            return set.First().Key;
        }

        public void RemoveMin()
        {
            set.Remove(FindMin());
        }

        public void RemoveMax()
        {
            set.Remove(FindMax());
        }

        public int Compare(T x, T y)
        {
            throw new NotImplementedException();
        }
    }
}