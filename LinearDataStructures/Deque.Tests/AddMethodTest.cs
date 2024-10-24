namespace Program.Tests
{
    public class AddMethodTest
    {
        [Theory]
        [InlineData(1, 2)]
        [InlineData(3, 4)]
        [InlineData(5, 6)]

        public void Add_OneItemToFirst_ReturnTrue(int num1, int num2)
        {
            //Arrange
            var deque = new Deque(num1);

            //Act
            deque.AddFirst(num2);

            //Assert
            var firstStack = deque.First;
            Assert.Equal(2, deque.Count);
            Assert.Equal(2, firstStack.Count);
        }

        [Theory]
        [InlineData(1, 2, 3)]
        [InlineData(3, 4, 5)]
        [InlineData(5, 6, 7)]

        public void Add_TwoItemsToFirst_ReturnTrue(int num1, int num2, int num3)
        {
            //Arrange
            var deque = new Deque(num1);

            //Act
            deque.AddFirst(num2);
            deque.AddFirst(num3);

            //Assert
            var firstStack = deque.First;
            Assert.Equal(3, deque.Count);
            Assert.Equal(3, firstStack.Count);
        }


        [Theory]
        [InlineData(1, 2, 3)]
        [InlineData(3, 4, 5)]
        [InlineData(5, 6, 7)]

        public void Add_AddItemsToFirstAndSecond_ReturnTrue(int num1, int num2, int num3)
        {
            //Arrange
            var deque = new Deque(num1);

            //Act
            deque.AddFirst(num2);
            deque.AddSecond(num3);

            //Assert
            var firstStack = deque.First;
            var secondStack = deque.Second;
            Assert.Equal(3, deque.Count);
            Assert.Equal(2, firstStack.Count);
            Assert.Equal(2, secondStack.Count);
        }

        [Theory]
        [InlineData(1, 2, 3)]
        [InlineData(3, 4, 5)]
        [InlineData(5, 6, 7)]

        public void Add_FirstNoBottom_AddBottomToFirstAndSecond(int num1, int num2, int num3)
        {
            //Arrange
            var deque = new Deque(num1);
            deque.AddSecond(num2);
            deque.RemoveFirst();

            //Act
            deque.AddFirst(num3);

            //Assert
            Assert.Equal(1, deque.First.Count);
            Assert.Equal(num3, deque.First.Top.Element);
            Assert.Equal(2, deque.Second.Count);
            Assert.Equal(2, deque.Count);
            Assert.Equal(num2, deque.Second.Top.Element);
        }

        [Theory]
        [InlineData(1, 2, 3)]
        [InlineData(3, 4, 5)]
        [InlineData(5, 6, 7)]

        public void Add_SecondNoBottom_AddBottomToFirstAndSecond(int num1, int num2, int num3)
        {
            //Arrange
            var deque = new Deque(num1);
            deque.AddFirst(num2);
            deque.RemoveSecond();

            //Act
            deque.AddSecond(num3);

            //Assert
            Assert.Equal(2, deque.First.Count);
            Assert.Equal(num2, deque.First.Top.Element);
            Assert.Equal(1, deque.Second.Count);
            Assert.Equal(2, deque.Count);
            Assert.Equal(num3, deque.Second.Top.Element);
        }

        [Theory]
        [InlineData(1, 2)]
        [InlineData(3, 4)]
        [InlineData(5, 6)]

        public void Add_FirstAndSecondNoBottom_AddBottomToSecondAndFirst(int num1, int num2)
        {
            //Arrange
            var deque = new Deque(num1);
            deque.RemoveFirst();

            //No need to remove deque.Second because SwapBottom() in RemoveFirst() removes both bottoms


            //Act
            deque.AddSecond(num2);

            //Assert

            Assert.Equal(1, deque.First.Count);
            Assert.Equal(num2, deque.First.Top.Element);

        }

        [Theory]
        [InlineData(1, 2)]
        [InlineData(3, 4)]
        [InlineData(5, 6)]

        public void Add_FirstAndSecondNoBottom_AddBottomToFirstAndSecond(int num1, int num2)
        {
            //Arrange
            var deque = new Deque(num1);
            deque.RemoveSecond();

            //No need to remove deque.Second because SwapBottom() in RemoveSecond() removes both bottoms


            //Act
            deque.AddFirst(num2);

            //Assert

            Assert.Equal(1, deque.First.Count);
            Assert.Equal(num2, deque.First.Top.Element);

        }
    }
}

