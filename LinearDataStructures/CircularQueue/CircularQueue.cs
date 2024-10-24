using System.Xml.Linq;

namespace Program
{
    public class CircularQueue<T> where T : struct
    {
        private int capacity = 8;
        private T[] array = new T[8];
        private int headIndex;
        private int tailIndex;
        private int count;

        public int Capacity { get => capacity; set => capacity = value; }

        public T[] Array { get => array; set => array = value; }

        public int HeadIndex { get => headIndex; set => headIndex = value; }

        public int TailIndex { get => tailIndex; set => tailIndex = value; }

        public int Count { get => count; set => count = value; }

        public T this[int index]
        {
            get
            {
                if (index >= Capacity || index < 0)
                {
                    throw new ArgumentOutOfRangeException(
                    "Invalid index: " + index);
                }

                var currElement = 0;

                for (int i = 0; i < index; i++)
                {
                    currElement++;
                }

                return Array[currElement];
            }

            set
            {
                if (index >= Capacity || index < 0)
                {
                    throw new ArgumentOutOfRangeException(
                    "Invalid index: " + index);
                }

                var currElement = 0;

                for (int i = 0; i < index; i++)
                {
                    currElement++;
                }

                Array[currElement] = (T)value;
            }
        }

        public void Enqueue(T item)
        {
            if ((TailIndex == Capacity - 1) && (Count != Capacity))
            {
                TailIndex = 0;
                Array[TailIndex] = item;
                Count++;
            }

            else if ((Count == Capacity) && (HeadIndex != 0))
            {
                var array = new T[capacity * 2];
                var currIndex = headIndex;
                var currNewIndex = 0;
                while (currIndex != TailIndex)
                {
                    if (currIndex < Capacity)
                    {
                        array[currNewIndex] = Array[currIndex];
                        currNewIndex++;
                        currIndex++;
                    }

                    else
                    {
                        currIndex = 0;
                    }
                }

                Capacity *= 2;
                HeadIndex = 0;
                array[currNewIndex] = Array[TailIndex];
                TailIndex = currNewIndex + 1;
                array[TailIndex] = item;
                Array = array;
                Count++;
            }

            else if ((Count == Capacity) && (HeadIndex == 0))
            {
                Capacity *= 2;
                var array = new T[Capacity];
                Array.CopyTo(array, 0);
                TailIndex++;
                array[TailIndex] = item;
                Array = array;
                Count++;
            }

            else
            {
                if (count != 0)
                    TailIndex++;
                Array[TailIndex] = item;
                Count++;
            }
        }

        public T Dequeue()
        {
            ValidateQueue();
            if (Count == 1)
            {
                var item = Array[HeadIndex];
                Array[HeadIndex] = default(T);
                HeadIndex = 0;
                TailIndex = 0;
                Count--;
                return item;
            }

            else if ((TailIndex < HeadIndex) && (HeadIndex == Capacity))
            {
                HeadIndex = 0;
                var item = Array[HeadIndex];
                Array[HeadIndex] = default(T);
                HeadIndex++;
                Count--;
                return item;
            }

            else
            {
                var item = Array[HeadIndex];
                Array[HeadIndex] = default(T);
                HeadIndex++;
                Count--;
                return item;
            }

        }

        public T Peek()
        {
            ValidateQueue();
            return Array[HeadIndex];
        }

        public void ValidateQueue()
        {
            if (Count == 0)
            {
                throw new InvalidOperationException($"The queue is empty");
            }
        }
    }
}