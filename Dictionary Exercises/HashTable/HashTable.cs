using System.Collections;

namespace ImplementHashTable
{
    public class HashTable<K, T> : IEnumerable<KeyValuePair<K, T>>
        where K : notnull
        where T : notnull
    {
        private KeyValuePair<K, T>[] table;
        private const float DEFAULT_LOAD_FACTOR = 0.75f;
        private double treshold;

        public HashTable(int capacity)
        {
            table = new KeyValuePair<K, T>[capacity];
            this.Capacity = capacity;
            this.treshold = Capacity * DEFAULT_LOAD_FACTOR;
        }

        public HashTable()
        {
            table = new KeyValuePair<K, T>[Capacity];
            this.treshold = Capacity * DEFAULT_LOAD_FACTOR;
        }

        public IEnumerable<K> Keys
        {
            get
            {
                var collection = new List<K>();
                foreach (var kv in table)
                {
                    if (!kv.Equals(default(KeyValuePair<K, T>)))
                    {
                        collection.Add(kv.Key);
                    }
                }

                return collection;
            }

        }

        public int Count { get; private set; } = 0;

        public long Capacity { get; private set; } = 16;

        public void Add(K key, T value)
        {
            if ((key is null))
            {
                throw new ArgumentNullException($"The key is null");
            }

            if ((value is null))
            {
                throw new ArgumentNullException($"The value is null");
            }

            if (Count >= treshold)
            {
                Expand();
                Add(key, value);
            }

            else
            {
                long hash = CalculateHash(key);

                if (IsPairDefault(hash))
                {
                    table[hash] = new KeyValuePair<K, T>(key, value);
                    Count++;
                }
            }
        }

        private void Expand()
        {
            Capacity *= 2;
            treshold = Capacity * DEFAULT_LOAD_FACTOR;
            var oldTable = new KeyValuePair<K, T>[Capacity];
            table.CopyTo(oldTable, 0);
            //var oldTable = table;
            //table = new KeyValuePair<K, T>[Capacity];
            //for (int i = 0; i < Count; i++)
            //{
            //    if (!oldTable[i].Equals(default(KeyValuePair<K, T>)))
            //    {
            //        table[i] = new KeyValuePair<K, T>(oldTable[i].Key, oldTable[i].Value);
            //    }
            //}
            table = oldTable;
        }

        public bool Remove(K key)
        {
            if (ContainsKey(key))
            {
                long hash = CalculateHash(key);

                if (IsPairDefault(hash))
                {
                    return false;
                }

                else
                {
                    table[hash] = default(KeyValuePair<K, T>);
                    Count--;
                    return true;
                }
            }

            else
            {
                Console.WriteLine($"Key doesn't exist");
                return false;
            }

        }

        public void Clear()
        {
            var newTable = new KeyValuePair<K, T>[Capacity];
            table = newTable;
            Count = 0;
        }

        public T this[K key] { get => Find(key); set => Add(key, value); }


        public T Find(K key)
        {
            if (ContainsKey(key))
            {
                long hash = CalculateHash(key);

                if (IsPairDefault(hash))
                {
                    Console.WriteLine($"Nothing found");
                    return default(T);
                }

                else
                {
                    return table[hash].Value;
                }
            }

            else
            {
                Console.WriteLine($"Key doesn't exist");
                return default(T);
            }

        }

        public IEnumerator GetEnumerator()
        {
            return table.GetEnumerator();
        }

        IEnumerator<KeyValuePair<K, T>> IEnumerable<KeyValuePair<K, T>>.GetEnumerator()
        {
            foreach (KeyValuePair<K, T> pair in table)
            {
                if (!pair.Equals(default(KeyValuePair<K, T>)))
                {
                    yield return pair;
                }
            }
        }

        private bool IsPairDefault(long hash)
        {
            return table[hash].Equals(default(KeyValuePair<K, T>));
        }

        private bool IsKey(long hash, K key)
        {
            return table[hash].Key.Equals(key);
        }

        private long CalculateHash(long prevHash, int j)
        {
            return (long)((prevHash + 0.5 * j + 0.5 * j * j) % Capacity);
        }

        private long CalculateHash(K key)
        {
            int j = 0;
            var hash = key.GetHashCode() % Capacity;
            while (!IsPairDefault(hash) && !IsKey(hash, key))
            {
                j++;
                hash = CalculateHash(hash, j);
            }

            return hash;
        }

        public bool ContainsKey(K key)
        {
            foreach (var item in Keys)
            {
                if (item.Equals(key))
                {
                    return true;
                }
            }

            return false;
        }
    }
}