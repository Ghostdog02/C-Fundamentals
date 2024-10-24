namespace Program
{
    public class Program
    {
        static void Main(string[] args)
        {
            // Create the binary tree from the sample
            BinaryTree binaryTree =
                new BinaryTree(14,
                    new BinaryTree(19,
                        new BinaryTree(23),
                        new BinaryTree(6,
                            new BinaryTree(10),
                            new BinaryTree(21))),
                    new BinaryTree(15,
                        new BinaryTree(3),
                        null));
            // Traverse and print the tree in in-order manner
            binaryTree.TraverseInOrder();
            binaryTree.PrintSum();
            // Console output:
            // 23 19 10 6 21 14 3 15
        }
    }
}