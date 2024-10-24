using System.Collections;

namespace HashTableWithMultipleValues
{
    public class ValuesCollection<T> : IEnumerable
    {
        public List<T> Values { get; } = new List<T>();

        public void Add(T value)
        {
            Values.Add(value);
        }

        public IEnumerator GetEnumerator()
        {
            foreach (var value in Values)
            {
                yield return value;
            }
        }
    }

    public class Program
    {
        static void Main(string[] args)
        {
            var table = new Dictionary<string, ValuesCollection<string>>();
            var values = new ValuesCollection<string>();
            values.Add("a");
            values.Add("b");
            values.Add("c");
            table.Add("a", values);
            foreach (var value in values)
            {
                Console.WriteLine(value);
            }
        }
    }
}