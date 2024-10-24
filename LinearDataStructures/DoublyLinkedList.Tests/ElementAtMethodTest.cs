namespace Program.Tests
{
    public class ElementAtMethodTest
    {
        [Theory]
        [InlineData(1, 2, 3)]
        [InlineData(3, 4, 5)]
        [InlineData(5, 6, 7)]

        public void ElementAt_ListWith3Elements_ReturnIndex(int num1, int num2, int num3)
        {
            //Assert
            var list = new DoublyLinkedList();
            list.Add(num1);
            list.Add(num2);
            list.Add(num3);

            //Act
            var element1 = list.ElementAt(0);
            var element2 = list.ElementAt(1);
            var element3 = list.ElementAt(2);

            //Assert
            Assert.Equal((num1, num2, num3), (element1, element2, element3));
        }

        [Theory]
        [InlineData(1, 2, 3)]
        [InlineData(3, 4, 5)]
        [InlineData(5, 6, 7)]

        public void ElementAt_InvalidIndex_ReturnIndex(int num1, int num2, int num3)
        {
            //Assert
            var list = new DoublyLinkedList();
            list.Add(num1);
            list.Add(num2);
            list.Add(num3);

            //Assert and Act
            Assert.Throws<ArgumentOutOfRangeException>(() => list.ElementAt(5));
            Assert.Throws<ArgumentOutOfRangeException>(() => list.ElementAt(-1));
            Assert.Throws<ArgumentOutOfRangeException>(() => list.ElementAt(3));
        }
    }
}

