namespace GenericList
{
    public class GenericList<T>
    {
        private const int initialElementCount = 10;
        private T[] array;
        private int count;

        public int Count { get => array.Length; }

        public GenericList()
        {
            array = new T[initialElementCount];
            this.count = 0;
        }

        public GenericList(int count)
        {
            array = new T[count];
            this.count = 0;
        }

        public GenericList(List<T> list)
        {
            array = list.ToArray();
            count = array.Length;
        }

        public T this[int index]
        {
            get
            {
                if (index >= array.Length)
                {
                    throw new IndexOutOfRangeException($"The Index {index} is larger than array lenght");
                }
                return array[index];
            }

            set
            {
                if (index >= array.Length)
                {
                    throw new IndexOutOfRangeException($"The Index {index} is larger than array lenght");
                }

                array[index] = value;
            }
        }

        public T ReturnElementAt(int index)
        {
            if (index >= 0 && index < array.Length)
                return array[index];
            else
                throw new IndexOutOfRangeException($"The index {index} is out of the range of array");
        }

        public void AddElement(T element)
        {
            if (count == array.Length)
            {
                T[] array1 = new T[count * 2];
                array1[count] = element;
                count++;
                array = array1;
            }

            array[count] = element;
            count++;
        }

        public void RemoveElementAt(int index)
        {
            if (index >= 0 && index < array.Length)
            {
                T[] array1 = new T[array.Length - 1];
                int indexCount = 0;
                for (int i = 0; i < array.Length; i++)
                {
                    if (i != index)
                    {
                        array1[indexCount] = array[i];
                        indexCount++;
                    }
                }
                array = array1;
            }

            else
                throw new IndexOutOfRangeException($"The index {index} is out of the range of array");
        }

        public void InsertAt(T element, int index)
        {
            if (index >= 0 && index < array.Length)
            {
                var array1 = new T[array.Length + 1];
                for (int i = 0; i < index; i++)
                {
                    array1[i] = array[i];
                }

                array1[index] = element;
                int count = index + 1;
                for (int i = index; i < array.Length; i++)
                {
                    array1[count] = array[i];
                    count++;
                }
                array = array1;
            }

            else
                throw new IndexOutOfRangeException($"The index {index} is out of the range of array");
        }

        public void Clear()
        {
            T[] array1 = new T[0];
            array = array1;
            Console.WriteLine(array.Length);
        }

        public int IndexOf(T element)
        {
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i].Equals(element))
                {
                    return i;
                }
            }
            return -1;
        }

        public override string ToString()
        {
            string result = "";
            for (int i = 0; i < array.Length; i++)
            {
                result += $"{array[i]}";
            }
            return result;
        }
    }

    class Program
    {
        static void Main() { }
    }
}