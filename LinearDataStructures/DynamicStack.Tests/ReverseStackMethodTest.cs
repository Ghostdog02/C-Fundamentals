namespace Program.Tests
{
    public class ReverseStackMethodTest
    {
        [Fact]

        public void ReverseStack_StackWithThreeElements_ReturnTrue()
        {
            //Arrange
            var stack = new DynamicStack();
            stack.Push(1);
            stack.Push(2);
            stack.Push(3);

            //Act
            var reversedStack = stack.ReverseStack();

            //Assert
            Assert.Equal(3, reversedStack.Count);
            Assert.Equal(1, reversedStack.Top.Element);
        }

        [Fact]

        public void ReverseStack_StackWithOneElement_ReturnTrue()
        {
            //Arrange
            var stack = new DynamicStack();
            stack.Push(1);
            
            //Act
            var reversedStack = stack.ReverseStack();

            //Assert
            Assert.Equal(1, reversedStack.Count);
            Assert.Equal(1, reversedStack.Top.Element);
        }

        [Fact]

        public void ReverseStack_EmptyStack_ThrowException()
        {
            //Arrange
            var stack = new DynamicStack();
            
            //Act and Assert
            Assert.Throws<InvalidOperationException>(() => stack.ReverseStack());
        }
    }
}
