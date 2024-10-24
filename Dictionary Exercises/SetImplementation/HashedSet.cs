using ImplementHashTable;
using System.Collections;
using System.Linq;

namespace SetImplementation
{
    public class HashedSet<T> : IEnumerable<T>
        where T : notnull
    {
        private HashTable<T, bool> set;

        public HashedSet()
        {
            set = new HashTable<T, bool>();
        }

        public void Add(T item)
        {
            set.Add(item, true);
        }

        public int Find(T item)
        {
            int index = 0;

            foreach (T item2 in set.Keys)
            {
                if (item.Equals(item2))
                {
                    return index;
                }

                index++;
            }

            return -1;
        }

        public bool Remove(T item)
        {
            bool result = set.Remove(item);
            return result;
        }

        public int Count()
        {
            return set.Count;
        }

        public void Clear()
        {
            set.Clear();
        }

        public HashedSet<T> Union(HashedSet<T> other)
        {
            var union = new HashedSet<T>();
            foreach (T item in set)
            {
                union.Add(item);
            }

            foreach (T item in other)
            {
                union.Add(item);
            }

            return union;
        }

        public HashedSet<T> Intersect(HashedSet<T> other)
        {
            var intersection = new HashedSet<T>();

            foreach (T item in set)
            {
                foreach (T item2 in other)
                {
                    if (item.Equals(item2))
                    {
                        intersection.Add(item2);
                    }
                }
                set.Add(item, true);
            }

            return intersection;
        }

        IEnumerator<T> IEnumerable<T>.GetEnumerator()
        {
            return (IEnumerator<T>)set.GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            foreach (KeyValuePair<T, bool> pair in set)
            {
                if (!pair.Equals(default(KeyValuePair<T, bool>)))
                {
                    yield return pair.Key;
                }
            }
        }
    }
}