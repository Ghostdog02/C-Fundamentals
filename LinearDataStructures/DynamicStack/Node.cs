namespace Program
{
    public class Node
    {
        private object element;
        private Node next;

        public object Element { get => element; set => element = value; }

        public Node Next { get => next; set => next = value; }

        public Node(object element)
        {
            this.Element = element;
            Next = null;
        }

        public Node(object element, Node prevNode)
        {
            this.Element = element;
            this.Next = prevNode;
        }

       
    }
}

