namespace DictionaryWithTwoKeys
{
    public class BiDictionary<K1, K2, T>
    {
        private Dictionary<K1, List<T>> dictionary1 { get; } = new();

        private Dictionary<K2, List<T>> dictionary2 { get; } = new();

        //Multiply by two beacause GetKeys() method returns Pair of two keys
        public int KeysCount { get => GetKeys().Count * 2; }

        public List<T> FindByFirstKey(K1 key1)
        {
            if (!dictionary1.ContainsKey(key1))
            {
                throw new KeyNotFoundException($"Key {key1} isn't in the BiDictionary");
            }

            return dictionary1[key1];
        }

        public List<T> FindBySecondKey(K2 key2)
        {

            if (!dictionary2.ContainsKey(key2))
            {
                throw new KeyNotFoundException($"Key {key2} isn't in the BiDictionary");
            }

            return dictionary2[key2];
        }

        public List<T> FindByBothKeys(K1 key1, K2 key2)
        {
            if (dictionary1.ContainsKey(key1))
            {
                return dictionary1[key1];
            }

            else
            {
                return dictionary2[key2];
            }
        }

        public void Add(K1 key1, K2 key2, T value)
        {
            if (dictionary1.ContainsKey(key1))
            {
                dictionary1[key1].Add(value);
            }

            else
            {
                var list = new List<T>();
                list.Add(value);
                dictionary1.Add(key1, list);
            }

            if (dictionary2.ContainsKey(key2))
            {
                dictionary2[key2].Add(value);
            }

            else
            {
                var list = new List<T>();
                list.Add(value);
                dictionary2.Add(key2, list);
            }
        }

        public bool Remove(K1 key1, K2 key2)
        {
            //if we have keys with different values return false
            if (!dictionary1[key1].Equals(dictionary2[key2]))
            {
                return false;
            }

            var isKeyRemovedInDict1 = dictionary1.Remove(key1);
            var isKeyRemovedInDict2 = dictionary2.Remove(key2);
            return isKeyRemovedInDict1 && isKeyRemovedInDict2;
        }

        public List<Tuple<K1, K2>> GetKeys()
        {
            var keys = new List<Tuple<K1, K2>>();
            var keysDict1 = dictionary1.Keys.ToList();
            var keysDict2 = dictionary2.Keys.ToList();
            for (int i = 0; i < keysDict1.Count; i++)
            {
                var pair = Tuple.Create(keysDict1[i], keysDict2[i]);
                keys.Add(pair);
            }
            return keys;
        }

        public void PrintKeys()
        {
            var keys = GetKeys();
            foreach (var pair in keys)
            {
                Console.WriteLine(pair.Item1);
                Console.WriteLine(pair.Item2);
            }
        }
    }

    public class Program
    {
        static void Main()
        {
            //BiDictionary<int, int, int> dictionary = new();
            //dictionary.Add(1, 2, 3);
            //dictionary.Add(1, 5, 6);
            //dictionary.Add(4, 5, 6);
            //foreach (var element in dictionary.FindByFirstKey(1))
            //{
            //    Console.WriteLine(element);
            //}
        }
    }
}
