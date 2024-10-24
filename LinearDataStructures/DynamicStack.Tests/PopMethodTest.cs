namespace Program.Tests
{
    public class PopMethodTest
    {
        [Theory]
        [InlineData(1, 2)]
        [InlineData(3, 4)]
        [InlineData(5, 6)]

        public void Pop_StackWithTwoElements_ReturnTrue(int num1, int num2)
        {
            //Assert
            var stack = new DynamicStack();
            stack.Push(num1);
            stack.Push(num2);

            //Act
            var actual = stack.Pop();

            //Assert
            Assert.Equal(num2, actual.Element);
            Assert.Equal(num1, stack.Top.Element);
            Assert.Equal(1, stack.Count);
        }

        [Theory]
        [InlineData(1)]
        [InlineData(3)]
        [InlineData(5)]

        public void Pop_StackWithOneElement_ReturnTrue(int num1)
        {
            //Assert
            var stack = new DynamicStack();
            stack.Push(num1);
           
            //Act
            var actual = stack.Pop();

            //Assert
            Assert.Equal(num1, actual.Element);
            Assert.Null(stack.Top);
            Assert.Equal(0, stack.Count);
        }

        [Fact]

        public void Pop_StackWithZeroElements_ThrowException()
        {
            //Assert
            var stack = new DynamicStack();

            //Act and Assert
            Assert.Throws<InvalidOperationException>(() => stack.Pop());
        }
    }
}

