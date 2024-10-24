namespace CalculateAverageAndSumOfSequence
{
    public class DynamicList
    {
        private class Node
        {
            private object element;
            public Node next;

            public object Element { get => element; set => element = value; }

            public Node Next { get => next; set => next = value; }

            public Node(object element, Node prevNode)
            {
                this.element = element;
                prevNode.Next = this;
            }

            public Node(object element)
            {
                this.Element = element;
                Next = null;
            }
        }

        private Node head;
        private Node tail;
        private int count;

        public int Count { get => count; }

        public DynamicList()
        {
            this.head = null;
            this.tail = null;
            this.count = 0;
        }

        public object this[int index]
        {
            get
            {
                if (index >= count || index < 0)
                {
                    throw new ArgumentOutOfRangeException(
                    "Invalid index: " + index);
                }

                Node currentNode = this.head;

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

                Node currentNode = this.head;

                for (int i = 0; i < index; i++)
                {
                    currentNode = currentNode.Next;
                }

                currentNode.Element = value;
            }
        }

        public int CalculateSum(DynamicList list)
        {
            int sum = 0;
            int currentIndex = 0;
            while (currentIndex < count)
            {
                sum += int.Parse(list[currentIndex].ToString());
                currentIndex++;
            }

            return sum;
        }

        public int CalculateAverage(DynamicList list)
        {
            return CalculateSum(list) / count;
        }

        public void Add(object item)
        {
            if (head == null)
            {
                head = new Node(item);
                tail = head;
            }

            else
            {
                Node newNode = new Node(item, tail);
                tail = newNode;
            }
            count++;
        }

        public void Sort(DynamicList list)
        {
            if (list.count == 0)
                throw new ArgumentNullException($"List {list} is Empty");

            else if (list.count == 1)
            {
                return;
            }

            else
            {
                for (int i = 0; i < list.count; i++)
                {
                    for (int j = i + 1; j < list.count; j++)
                    {
                        var num1 = int.Parse(list[i].ToString());
                        var num2 = int.Parse(list[j].ToString());
                        if (num1 > num2)
                        {
                            var oldNum = list[i];
                            list[i] = list[j];
                            list[j] = oldNum;
                        }
                    }
                }
            }
        }
    }
}