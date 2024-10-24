namespace Program.Tests
{
    public class PushMethodTest
    {
        [Theory]
        [InlineData(1, 2)]
        [InlineData(2, 3)]
        [InlineData(3, 4)]

        public void Push_TwoNumbers_ReturnTrue(int number1, int number2)
        {
            //Arrange
            DynamicStack stack = new DynamicStack();

            //Act
            stack.Push(number1);
            stack.Push(number2);

            //Assert
            Assert.Equal(2, stack.Count);
            Assert.Equal(number2, stack.Top.Element);
            Assert.Equal(number1, stack.Top.Next.Element);
        }

        [Theory]
        [InlineData(1)]
        [InlineData(2)]
        [InlineData(3)]

        public void Push_OneNumber_ReturnTrue(int number1)
        {
            //Arrange
            DynamicStack stack = new DynamicStack();

            //Act
            stack.Push(number1);
           
            //Assert
            Assert.Equal(1, stack.Count);
            Assert.Null(stack.Top.Next);
            Assert.Equal(number1, stack.Top.Element);
        }
    }
}

