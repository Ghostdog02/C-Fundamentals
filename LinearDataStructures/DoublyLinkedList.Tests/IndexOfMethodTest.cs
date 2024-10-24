namespace Program.Tests
{
    public class IndexOfMethodTest
    {
        [Theory]
        [InlineData(1, 3, 4)]
        [InlineData(2, 4, 5)]
        [InlineData(5, 6, 8)]

        public void IndexOf_ListWith3Elements_FindNumber(int num1, int num2, int num3)
        {
            //Assert
            var list = new DoublyLinkedList();
            list.Add(num1);
            list.Add(num2);
            list.Add(num3);

            //Act
            int index = list.IndexOf(num2);

            //Assert
            Assert.Equal(1, index);
        }

        [Theory]
        [InlineData(1, 3, 4)]
        [InlineData(2, 4, 5)]
        [InlineData(5, 6, 8)]

        public void IndexOf_ListWith3ElementsNoMatches_ReturnIndex(int num1, int num2, int num3)
        {
            //Assert
            var list = new DoublyLinkedList();
            list.Add(num1);
            list.Add(num2);
            list.Add(num3);

            //Act
            int index = list.IndexOf(9);

            //Assert
            Assert.Equal(-1, index);
        }
    }
}

