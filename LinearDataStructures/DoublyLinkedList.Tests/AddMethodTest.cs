namespace Program.Tests
{
    public class AddMethodTest
    {

        [Theory]
        [InlineData(0, 3)]
        [InlineData(1, 5)]
        [InlineData(2, 6)]

        public void Add_2NumbersFrom0To10_InitializeList(int number1, int number2)
        {
            //Arrange
            DoublyLinkedList list = new DoublyLinkedList();

            //Act
            list.Add(number1);
            list.Add(number2);

            //Assert
            Assert.Equal((number1, number2), (list[0], list[1]));
        }

        [Theory]
        [InlineData(0, 3)]
        [InlineData(1, 5)]
        [InlineData(2, 6)]

        public void Add_2NumbersFrom0To10_SetLink(int number1, int number2)
        {
            //Arrange
            DoublyLinkedList list = new DoublyLinkedList();

            //Act
            list.Add(number1);
            list.Add(number2);

            //Assert
            Node head = list.Head;
            Node tail = list.Tail;
            Assert.Null(head.Previous);
            Assert.Equal(tail, head.Next);
            Assert.Equal(head, tail.Previous);
            Assert.Null(tail.Next);
        }

        [Theory]
        [InlineData(0, 3, 4)]
        [InlineData(1, 5, 5)]
        [InlineData(2, 6, 7)]

        public void Add_3NumbersFrom0To10_SetLink(int number1, int number2, int number3)
        {
            //Arrange
            DoublyLinkedList list = new DoublyLinkedList();

            //Act
            list.Add(number1);
            list.Add(number2);
            list.Add(number3);

            //Assert
            Node head = list.Head;
            Node item = head.Next;
            Node tail = list.Tail;
            Assert.Null(head.Previous);
            Assert.Equal(item, head.Next);
            Assert.Equal(item, tail.Previous);
            Assert.Equal(head, item.Previous);
            Assert.Equal(tail, item.Next);
            Assert.Null(tail.Next);
        }

        [Theory]
        [InlineData(0, 3, 4)]
        [InlineData(1, 5, 5)]
        [InlineData(2, 6, 7)]

        public void Add_3NumbersFrom0To10_SetCount(int number1, int number2, int number3)
        {
            //Arrange
            DoublyLinkedList list = new DoublyLinkedList();

            //Act
            list.Add(number1);
            list.Add(number2);
            list.Add(number3);

            //Assert
            var count = list.Count;
            Assert.Equal(3, count);
        }
    }
}

