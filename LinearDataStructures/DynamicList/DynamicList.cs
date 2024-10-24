using System;
using System.Reflection;

namespace Program
{
    public class DynamicList<T>
    {
        public Node<T> head;
        public Node<T> tail;
        public int count;

        public DynamicList()
        {
            this.head = null;
            this.tail = null;
            this.count = 0;
        }

        public T this[int index]
        {
            get
            {
                if (index >= count || index < 0)
                {
                    throw new ArgumentOutOfRangeException(
                    "Invalid index: " + index);
                }

                Node<T> currentNode = this.head;

                for (int i = 0; i < index; i++)
                {
                    currentNode = currentNode.Next;
                }

                return currentNode.Element;
            }

            set
            {
                if (index >= count || index < 0)
                {
                    throw new ArgumentOutOfRangeException(
                    "Invalid index: " + index);
                }

                Node<T> currentNode = this.head;

                for (int i = 0; i < index; i++)
                {
                    currentNode = currentNode.Next;
                }

                currentNode.Element = value;
            }
        }

        public int CalculateSum(DynamicList<int> list)
        {
            int sum = 0;
            int currentIndex = 0;
            while (currentIndex < count)
            {
                sum += list[currentIndex];
                currentIndex++;
            }

            return sum;
        }

        public int CalculateAverage(DynamicList<int> list)
        {
            return CalculateSum(list) / count;
        }

        public void Add(T item)
        {
            if (head == null)
            {
                head = new Node<T>(item);
                tail = head;
            }

            else
            {
                Node<T> newNode = new Node<T>(item, tail);
                tail = newNode;
            }
            count++;
        }

        public Node<T> ReturnNode(int index)
        {
            if (index >= count || index < 0)
            {
                throw new ArgumentOutOfRangeException(
                "Invalid index: " + index);
            }

            Node<T> currentNode = this.head;

            for (int i = 0; i < index; i++)
            {
                currentNode = currentNode.Next;
            }

            return currentNode;
        }
              


    }

    public class Program
    {
        static void Main()
        {

            DynamicList<int> list = new DynamicList<int>();
            string line = "";
            while (true)
            {
                line = Console.ReadLine();
                if (line == " ")
                {
                    break;
                }

                list.Add(int.Parse(line));
            }

            Console.WriteLine(list.CalculateSum(list));
            Console.WriteLine(list.CalculateAverage(list));
        }
    }
}