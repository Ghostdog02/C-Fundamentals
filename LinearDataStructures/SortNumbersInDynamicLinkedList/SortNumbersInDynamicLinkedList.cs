using Program;

namespace Program
{
    public class SortNumbersInDynamicLinkedList
    {
        public void Sort(DynamicList<int> list)
        {
            int i, j, temp;
            bool swapped;
            for (i = 0; i < list.count - 1; i++)
            {
                swapped = false;
                for (j = 0; j < list.count - i - 1; j++)
                {
                    if (list[j] > list[j + 1])
                    {

                        // Swap arr[j] and arr[j+1]
                        temp = list[j];
                        list[j] = list[j + 1];
                        list[j + 1] = temp;
                        var currNode = list.head;

                        for (int f = 0; f < j; f++)
                        {
                            currNode = currNode.Next;
                        }

                        var node = list.ReturnNode(j + 1);
                        currNode.Next = node;
                        swapped = true;
                    }
                }

                // If no two elements were
                // swapped by inner loop, then break
                if (swapped == false)
                    break;
            }
        }
    }

    public class Program
    {
        public static void Main(string[] args)
        {
            SortNumbersInDynamicLinkedList sort = new();
            var list = new DynamicList<int>();
            list.Add(9);
            list.Add(1);
            list.Add(6);
            list.Add(0);
            sort.Sort(list);
            var currNode = list.head;
            while (currNode != null)
            {
                Console.WriteLine(currNode.Element);
                currNode = currNode.Next;
            }
        }
    }
}