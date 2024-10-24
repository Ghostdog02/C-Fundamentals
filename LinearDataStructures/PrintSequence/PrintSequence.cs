namespace Program
{
    public class PrintSequence
    {
        public static void Main()
        {
            int n = int.Parse(Console.ReadLine());
            Queue<int> queue = new Queue<int>();
            queue.Enqueue(n);
            int index = 0;
            Console.WriteLine("S =");
            while (queue.Count > 0)
            {
                index++;
                int current = queue.Dequeue();
                Console.WriteLine(" " + current);
                if (index == 50)
                {
                    return;
                }

                queue.Enqueue(current + 1);
                queue.Enqueue(2 * current + 1);
                queue.Enqueue(current + 2);

            }
        }
    }
}