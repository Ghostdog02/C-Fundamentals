namespace Program.Tests
{
    public class InsertMethodTest
    {
        [Theory]
        [InlineData(7, 0, 1, 2, 3)]
        [InlineData(4, 1, 0, 2, 3)]
        [InlineData(5, 2, 0, 1, 3)]

        public void Insert_ListWith3Elements_InsertNumber(int num, int index, int expectedIndex1, int expectedIndex2,
            int expectedIndex3)
        {
            //Assert
            var list = new DoublyLinkedList();
            list.Add(1);
            list.Add(2);
            list.Add(3);

            //Act
            list.Insert(num, index);

            //Assert
            Assert.Equal(num, list[index]);
            //Assert.Equal(1, list[expectedIndex1]);
            //Assert.Equal(2, list[expectedIndex2]);
            //Assert.Equal(3, list[expectedIndex3]);
        }
    }
}

