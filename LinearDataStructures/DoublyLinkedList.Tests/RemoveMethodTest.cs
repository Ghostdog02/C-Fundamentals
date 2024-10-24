namespace Program.Tests
{
    public class RemoveMethodTest
    {
        [Theory]
        [InlineData(1, 2, 3)]
        [InlineData(3, 5, 3)]
        [InlineData(3, 5, 6)]

        public void Remove_ListWith3Elements_RemoveSecondElement(int num1, int num2, int num3)
        {
            //Assert
            var list = new DoublyLinkedList();
            list.Add(num1);
            list.Add(num2);
            list.Add(num3);

            //Act
            int index = list.Remove(num2);

            //Assert
            Assert.Equal(2, list.Count);
            Assert.Equal(num1, list[0]);
            Assert.Equal(num3, list[1]);
            Assert.Equal(1, index);
        }

        [Theory]
        [InlineData(1, 2, 3)]
        [InlineData(3, 5, 4)]
        [InlineData(3, 5, 6)]

        public void Remove_ListWith3Elements_SetLinks(int num1, int num2, int num3)
        {
            //Assert
            var list = new DoublyLinkedList();
            list.Add(num1);
            list.Add(num2);
            list.Add(num3);

            //Act
            list.Remove(num2);

            //Assert
            var head = list.Head;
            var tail = list.Tail;
            Assert.Null(head.Previous);
            Assert.Equal(tail, head.Next);
            Assert.Equal(head, tail.Previous);
            Assert.Null(tail.Next);
        }

        [Theory]
        [InlineData(1, 2)]
        [InlineData(3, 5)]
        [InlineData(3, 7)]

        public void Remove_ListWith2Elements_RemoveSecondElement(int num1, int num2)
        {
            //Assert
            var list = new DoublyLinkedList();
            list.Add(num1);
            list.Add(num2);

            //Act
            int index = list.Remove(num2);

            //Assert
            Assert.Equal(1, list.Count);
            Assert.Equal(num1, list[0]);
            Assert.Throws<ArgumentOutOfRangeException>(() => list[1]);
            Assert.Equal(1, index);
        }

        [Theory]
        [InlineData(1, 2)]
        [InlineData(3, 5)]
        [InlineData(3, 7)]

        public void Remove_ListWith2Elements_SetLinks(int num1, int num2)
        {
            //Assert
            var list = new DoublyLinkedList();
            list.Add(num1);
            list.Add(num2);

            //Act
            list.Remove(num2);

            //Assert
            var head = list.Head;
            var tail = list.Tail;
            Assert.Null(head.Previous);
            Assert.Equal(tail, head);
            Assert.Null(head.Next);
            Assert.Null(tail.Previous);
            Assert.Null(tail.Next);
        }


        [Theory]
        [InlineData(1)]
        [InlineData(3)]
        [InlineData(5)]

        public void Remove_ListWith1Element_RemoveElement(int num1)
        {
            //Assert
            var list = new DoublyLinkedList();
            list.Add(num1);

            //Act
            int index = list.Remove(num1);

            //Assert
            Assert.Equal(0, list.Count);
            Assert.Throws<ArgumentOutOfRangeException>(() => list[0]);
            Assert.Equal(0, index);
        }

        [Theory]
        [InlineData(1)]
        [InlineData(3)]
        [InlineData(5)]

        public void Remove_ListWith1Element_SetNullHeadAndTail(int num1)
        {
            //Assert
            var list = new DoublyLinkedList();
            list.Add(num1);

            //Act
            list.Remove(num1);

            //Assert
            var head = list.Head;
            var tail = list.Tail;
            Assert.Null(head);
            Assert.Null(tail);

        }

        [Theory]
        [InlineData(1, 2)]
        [InlineData(3, 4)]
        [InlineData(5, 6)]

        public void Remove_NoMatchesFound_ReturnSameList(int num1, int num2)
        {
            //Assert
            var list = new DoublyLinkedList();
            list.Add(num1);
            list.Add(num2);
            var count = list.Count;

            //Act
            int index = list.Remove(0);

            //Assert
            var count1 = list.Count;
            var head = list.Head;
            var tail = list.Tail;
            Assert.Equal(count, count1);
            Assert.Equal(tail, head.Next);
            Assert.Equal(head, tail.Previous);
            Assert.Equal(-1, index);

        }
    }
}

