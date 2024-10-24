namespace Program.Tests
{
    public class ReturnElementsMethodTest
    {
        [Fact]
        public void ReturnElements_ListWith3Numbers_ReturnArray()
        {
            //Assert
            var list = new DoublyLinkedList();
            list.Add(1);
            list.Add(2);
            list.Add(3);

            //Act
            var array = list.ReturnElements();

            //Assert
            var currentNode = list.Head;
            var index = 0;
            while (currentNode != null)
            {
                Assert.Equal(currentNode, array[index]);
                index++;
                currentNode = currentNode.Next;
            }
        }
    }
}

