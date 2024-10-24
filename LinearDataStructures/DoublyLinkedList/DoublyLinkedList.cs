namespace Program
{
    public class DoublyLinkedList
    {
        private Node head;
        private Node tail;
        private int count;

        public Node Head { get => head; set => head = value; }

        public Node Tail { get => tail; set => tail = value; }

        public int Count { get => count; set => count = value; }

        public DoublyLinkedList()
        {
            this.Head = null;
            this.Tail = null;
            this.Count = 0;
        }

        public object this[int index]
        {
            get
            {
                if (index >= Count || index < 0)
                {
                    throw new ArgumentOutOfRangeException(
                    "Invalid index: " + index);
                }

                Node currentNode = this.Head;

                for (int i = 0; i < index; i++)
                {
                    currentNode = currentNode.Next;
                }

                return currentNode.Element;
            }

            set
            {
                if (index >= Count || index < 0)
                {
                    throw new ArgumentOutOfRangeException(
                    "Invalid index: " + index);
                }

                Node currentNode = this.Head;

                for (int i = 0; i < index; i++)
                {
                    currentNode = currentNode.Next;
                }

                currentNode.Element = value;
            }
        }

        public int CalculateSum(DoublyLinkedList list)
        {
            int sum = 0;
            int currentIndex = 0;
            while (currentIndex < Count)
            {
                sum += int.Parse(list[currentIndex].ToString());
                currentIndex++;
            }

            return sum;
        }

        public int CalculateAverage(DoublyLinkedList list)
        {
            return CalculateSum(list) / Count;
        }

        public void Add(object item)
        {
            if (Head == null)
            {
                Head = new Node(item);
                Tail = Head;
            }

            else
            {
                Node newNode = new Node(item, Tail, null);
                Tail = newNode;
            }
            Count++;
        }

        public int Remove(object item)
        {
            int currentIndex = 0;
            Node currentNode = Head;
            Node prevNode = null;

            while (currentNode != null)
            {
                if ((currentNode.Element != null && currentNode.Element.Equals(item)) ||
                    (currentNode.Element == null) && (item == null))
                {
                    break;
                }

                prevNode = currentNode;
                currentNode = currentNode.Next;
                currentIndex++;
            }

            if (currentNode != null)
            {
                Count--;
                if (Count == 0)
                {
                    Head = null;
                }

                else if (prevNode == null)
                {
                    Head = currentNode.Next;
                }

                else
                {
                    var currNext = currentNode.Next;
                    prevNode.Next = currNext;
                    if (currNext != null)
                        currNext.Previous = prevNode;
                }

                Node lastElement = null;
                if (this.Head != null)
                {
                    lastElement = this.Head;
                    while (lastElement.Next != null)
                    {
                        lastElement = lastElement.Next;
                    }
                }

                Tail = lastElement;
                return currentIndex;
            }

            else
            {
                return -1;
            }
        }

        public int IndexOf(object item)
        {
            int currentIndex = 0;
            Node currentNode = Head;

            while (currentNode != null)
            {
                if ((currentNode.Element != null && currentNode.Element.Equals(item))
                       || (currentNode.Element == null) && (item == null))
                {
                    return currentIndex;
                }

                currentNode = currentNode.Next;
                currentIndex++;
            }

            return -1;
        }

        public void Insert(object item, int index)
        {
            Node prevNode = null;
            var currentNode = Head;
            Node insertedItem = new Node(item);
            var currentIndex = 0;
            if (index > Count || index < 0)
            {
                throw new IndexOutOfRangeException($"Invalid index {index}");
            }

            while (currentIndex < index)
            {
                prevNode = currentNode;
                currentNode = currentNode.Next;
                currentIndex++;
            }

            Count++;
            insertedItem.Previous = currentNode.Previous;
            currentNode.Previous = insertedItem;
            insertedItem.Next = currentNode;
            if (prevNode != null)
                prevNode.Next = insertedItem;

            if (index == 0)
            {
                Head = insertedItem;
            }

            if (index == Count - 1)
            {
                Tail = insertedItem;
            }           
        }

        public object ElementAt(int index)
        {
            if (index > Count - 1 || index < 0)
            {
                throw new ArgumentOutOfRangeException($"Invalid index {index}");
            }

            var currentNode = Head;
            var currentIndex = 0;

            while (currentIndex < index)
            {
                currentNode = currentNode.Next;
                currentIndex++;
            }

            return currentNode.Element;

        }

        public object[] ReturnElements()
        {
            var currentNode = this.Head;
            Node[] array = new Node[Count];
            var currentIndex = 0;
            while (currentNode != null)
            {
                array[currentIndex] = currentNode;
                currentNode = currentNode.Next;
                currentIndex++;
            }

            return array;
        }

        static void Main()
        {

        }


    }
}