namespace Program
{
    public class DynamicStack
    {
        private Node top;
        private int count;

        public Node Top { get => top; set => top = value; }

        public int Count { get => count; set => count = value; }

        public DynamicStack()
        {
            this.Top = null;
            this.Count = 0;
        }

        public void Push(object element)
        {
            if (Top == null)
            {
                Top = new Node(element);
            }

            else
            {
                Node newNode = new Node(element, Top);
                //Top.Next = newNode;
                Top = newNode;
            }

            Count++;
        }

        public Node Pop()
        {
            ValidateStack();
            var top = Top;
            Top = Top.Next;
            Count--;
            return top;
        }

        public Node Peek()
        {
            ValidateStack();
            return Top;
        }

        public void Clear()
        {
            this.top = null;
            this.Count = 0;
        }

        public bool Contains(object element)
        {
            if (element == null)
            {
                throw new ArgumentNullException($"The provided element is null");
            }

            ValidateStack();

            var currentNode = Top;
            var doesContain = false;
            while (currentNode != null)
            {
                if (currentNode.Element.Equals(element))
                {
                    doesContain = true;
                }

                currentNode = currentNode.Next;
            }

            return doesContain;
        }

        public Node[] ToArray()
        {
            ValidateStack();
            Node[] array = new Node[Count];
            var currentNode = Top;
            var index = 0;
            while (currentNode != null)
            {
                array[index] = currentNode;
                currentNode = currentNode.Next;
                index++;
            }

            return array;
        }

        public void ValidateStack()
        {
            if (Count == 0)
            {
                throw new InvalidOperationException($"There are no elements in Stack");
            }
        }

        public override bool Equals(object obj)
        {
            if (!(obj is Node))
                return false;

            if (obj == null)
                return false;

            var currentNode = this.Top;
            var isEqual = false;
            while (currentNode != null)
            {
                if (currentNode.Element == obj)
                {
                    isEqual = true;
                }

                currentNode = currentNode.Next;
            }

            return isEqual;
        }

        public bool EqualsArray(Node[] obj)
        {
            if (!(obj is Node[]))
                return false;

            if (obj == null)
                return false;

            if (Count != obj.Length)
                return false;

            var currentNode = this.Top;
            var index = 0;
            var isEqual = true;
            while (currentNode != null)
            {
                var currentStackElement = currentNode.Element;
                var currentArrayElement = obj[index].Element;
                var equals = currentStackElement.Equals(currentArrayElement);
                if (index != Count - 1)
                {
                    var equalsNext = currentNode.Next.Element.Equals(obj[index].Next.Element);
                    if (!equals || !equalsNext)
                    {
                        isEqual = false;
                    }
                }

                else if (!equals)
                {
                    isEqual = false;
                }

                currentNode = currentNode.Next;
                index++;
            }

            return isEqual;
        }

        public bool EqualsStack(DynamicStack stack)
        {
            if (!(stack is DynamicStack))
                return false;

            if (stack == null)
                return false;

            if (Count != stack.Count)
                return false;

            var currentNode = this.Top;
            var currentArgumentNode = stack.Top;
            var index = 0;
            var isEqual = true;
            while (currentNode != null)
            {
                var currentNodeElement = currentNode.Element;
                var currentArgumentNodeElement = currentArgumentNode.Element;
                var equals = currentNodeElement.Equals(currentArgumentNodeElement);
                if (index != Count - 1)
                {
                    var equalsNext = currentNode.Next.Element.Equals(currentArgumentNode.Next.Element);
                    if (!equals || !equalsNext)
                    {
                        isEqual = false;
                    }
                }

                else if (!equals)
                {
                    isEqual = false;
                }

                currentNode = currentNode.Next;
                currentArgumentNode = currentArgumentNode.Next;
                index++;
            }

            return isEqual;
        }

        public DynamicStack ReverseStack()
        {
            ValidateStack();
            DynamicStack temp = new DynamicStack();

            var currentNode = Top;
            if (Count == 1)
            {
                temp.Push(currentNode.Element);
                return temp;
            }
                
            while (currentNode != null)
            {
                temp.Push(currentNode.Element);
                currentNode = currentNode.Next;
            }

            return temp;
        }

        static void Main() { }

    }
}