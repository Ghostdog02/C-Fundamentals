namespace Program
{
    public class Node<T>
    {
        private T element;
        private Node<T> next;

        public T Element { get => element; set => element = (T?)value; }

        public Node<T> Next { get => next; set => next = value; }


        public Node(T element, Node<T> prev)
        {
            this.Element = element;
            prev.Next = this;
        }

        public Node(T element)
        {
            this.Element = element;
            Next = null;
        }
    }
}
