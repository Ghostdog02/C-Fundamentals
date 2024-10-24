namespace Program
{
    public class FindSmallestSequence
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int m = int.Parse(Console.ReadLine());
            var queue = new Queue<int>();
            var list = new List<int>();
            //var additionByOne = new List<int>();
            //var additionByTwo = new List<int>();
            //var multiplyByTwo = new List<int>();
            //bool isAddOne;
            //bool isAddTwo;
            //bool isMultiplyTwo;
            int count = 1;
            queue.Enqueue(n);
            while (queue.Count > 0)
            {
                int current1 = queue.Dequeue();
                Console.WriteLine(current1);
                //if (list.Contains(m))
                //{
                //    //List<int> result;
                //    //if (additionByOne.Contains(m))
                //    //    result = additionByOne;

                //    //else if (additionByTwo.Contains(m))
                //    //    result = additionByTwo;

                //    //else
                //    //    result = multiplyByTwo;

                //    //var count = 1;
                //    //foreach (var number in result)
                //    //{

                //    //    Console.WriteLine($"Num {count} = {number}");
                //    //    count++;
                //    //}
                //    //var index = list.IndexOf(m);
                //    //if (index == list.Count - 1)
                //    //{
                //    //    for (int i = 2; i < list.Count; i += 3)
                //    //    {
                //    //        Console.WriteLine(list[i]);
                //    //    }
                //    //}

                //    //else if (index == list.Count - 2)
                //    //{
                //    //    for (int i = 1; i < list.Count; i += 3)
                //    //    {
                //    //        Console.WriteLine(list[i]);
                //    //    }
                //    //}

                //    //else
                //    //{
                //    //    for (int i = 0; i < list.Count; i += 3)
                //    //    {
                //    //        Console.WriteLine(list[i]);
                //    //    }
                //    //}
                //    //break;
                //}

                if (count == 100)
                {
                    break;
                }

                queue.Enqueue(current1 + 1);
                //current1 + 1;
                //current1 + 2;
                //current1 * 2;
                //current2 + 1;
                //current2 + 2;
                //current2 * 2;
                //current3 + 1;
                //current3 + 2;
                //current3 * 2;
                //list.Add(current1 + 1);
                //additionByOne.Add(current + 1);
                queue.Enqueue(current1 + 2);
                //list.Add(current1 + 2);
                //additionByTwo.Add(current + 2);
                queue.Enqueue(current1 * 2);
                //list.Add(current1 * 2);
                //multiplyByTwo.Add(current * 2);
                count++;
            }

        }
    }
}