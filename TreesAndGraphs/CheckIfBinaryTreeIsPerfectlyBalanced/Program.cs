namespace Program
{
    public class Program
    {
        static void Main(string[] args)
        {
            BinaryTree binaryTree =
    new BinaryTree(14,
        new BinaryTree(19,
            new BinaryTree(23),
            new BinaryTree(6,
                new BinaryTree(10),
                new BinaryTree(21,
                    new BinaryTree(1), 
                    null ))),
        new BinaryTree(15,
            new BinaryTree(3),
            null));

            binaryTree.TraverseInOrder(0);
            binaryTree.CheckBalance();
        }
    }
}