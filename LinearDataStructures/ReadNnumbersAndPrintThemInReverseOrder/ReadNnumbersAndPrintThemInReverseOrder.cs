namespace Program
{
    public class ReadNnumbersAndPrintThemInReverseOrder
    {
        static void Main()
        {
            int n = int.Parse(Console.ReadLine());
            var counter = 0;
            Stack<int> stack = new Stack<int>();
            while (counter < n)
            {
                var number = int.Parse(Console.ReadLine());
                stack.Push(number);
                counter++;
            }
            Console.WriteLine();
            WriteNumbersReversed(stack);
        }

        static void WriteNumbersReversed(Stack<int> stack)
        {
            while (stack.Count > 0)
            {
                var number = stack.Pop();
                Console.WriteLine(number);
            }
        }
    }
}