namespace Program
{
    public class Node
    {
        private object element;
        private Node next;
        private Node? previous;

        public object Element { get => element; set => element = value; }

        public Node Next { get => next; set => next = value; }

        public Node? Previous { get => previous; set => previous = value; }

        public Node(object element, Node prevNode, Node? nextNode)
        {
            this.Element = element;
            prevNode.Next = this;
            this.Next = nextNode;
            this.Previous = prevNode;
        }

        public Node(object element)
        {
            this.Element = element;
            Next = null;
            Previous = null;
        }

    }
}

