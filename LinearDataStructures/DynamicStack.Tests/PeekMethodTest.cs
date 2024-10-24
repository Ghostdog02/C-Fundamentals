namespace Program.Tests
{
    public class PeekMethodTest
    {
        [Theory]
        [InlineData(0)]
        [InlineData(1)]
        [InlineData(2)]

        public void Peek_StackWithOneElement_ReturnTrue(int num)
        {
            //Assert
            var stack = new DynamicStack();
            stack.Push(num);

            //Act
            int actual = (int)stack.Peek().Element;

            //Assert
            Assert.Equal(num, actual);
            Assert.Equal(1, stack.Count);
            Assert.Null(stack.Top.Next);
        }

        [Theory]
        [InlineData(0, 1)]
        [InlineData(1, 2)]
        [InlineData(2, 3)]

        public void Peek_StackWithTwoElements_ReturnTrue(int num1, int num2)
        {
            //Assert
            var stack = new DynamicStack();
            stack.Push(num1);
            stack.Push(num2);

            //Act
            int actual = (int)stack.Peek().Element;

            //Assert
            Assert.Equal(num2, actual);
            Assert.Equal(2, stack.Count);
        }

        [Fact]      

        public void Peek_StackWithZeroElements_ThrowException()
        {
            //Assert
            var stack = new DynamicStack();                   

            //Act and Assert
            Assert.Throws<InvalidOperationException>(() => stack.Peek());
        }
    }
}

