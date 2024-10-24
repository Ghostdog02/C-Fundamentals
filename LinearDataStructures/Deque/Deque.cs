using static Program.DynamicStack;

namespace Program
{
    public class Deque
    {
        private DynamicStack first = new DynamicStack();
        private DynamicStack second = new DynamicStack();
        private int count = 0;

        public DynamicStack First { get => first; set => first = value; }

        public DynamicStack Second { get => second; set => second = value; }

        public int Count { get => count; set => count = value; }

        public Deque(object bottom)
        {
            first.Push(bottom);
            second.Push(bottom);
            Count++;
        }

        public void AddFirst(object item)
        {
            if ((First.Count == 0) && (Second.Count != 0))
            {
                AddBottom(first, second, item);
            }

            else if ((First.Count == 0) && (Second.Count == 0))
            {
                first.Push(item);
                second.Push(item);
            }

            else
            {
                first.Push(item);
            }

            Count++;
        }

        public void AddSecond(object item)
        {
            if ((Second.Count == 0) && (First.Count != 0))
            {
                AddBottom(second, first, item);
            }

            else if ((First.Count == 0) && (Second.Count == 0))
            {
                first.Push(item);
                second.Push(item);
            }

            else
            {
                second.Push(item);
            }

            Count++;
        }

        public void RemoveFirst()
        {
            first.ValidateStack();
            SwapBottom(first, second);

        }

        public void RemoveSecond()
        {
            second.ValidateStack();
            SwapBottom(second, first);

        }

        public void SwapBottom(DynamicStack stack1, DynamicStack stack2)
        {
            if ((stack1.Count == 1) && (stack2.Count != 1))
            {
                stack1.Pop();
                var temp1 = stack2.ReverseStack();
                temp1.Pop();
                var temp2 = temp1.ReverseStack();

                if (stack2.EqualsStack(second))
                {
                    second = temp2;
                    first = stack1;
                }


                else
                {
                    first = temp2;
                    second = stack1;
                }

            }

            else if ((stack1.Count == 1) && (stack2.Count == 1))
            {
                stack1.Pop();
                stack2.Pop();
                first = stack1;
                second = stack2;
            }

            else
            {
                stack1.Pop();
            }

            Count--;
        }       

        public void AddBottom(DynamicStack stack1, DynamicStack stack2, object item)
        {
            stack1.Push(item);
            var temp1 = stack2.ReverseStack();
            temp1.Push(item);
            var temp2 = temp1.ReverseStack();
            if (stack2.EqualsStack(second))
            {
                second = temp2;
                first = stack1;
            }

            else
            {
                first = temp2;
                second = stack1;
            }
        }

        static void Main() { }


    }
}