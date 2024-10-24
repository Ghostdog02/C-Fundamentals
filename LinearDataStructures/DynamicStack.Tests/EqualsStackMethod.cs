namespace Program.Tests
{
    public class EqualsStackMethod
    {
        [Theory]
        [InlineData(1, 2, 3)]
        [InlineData(2, 3, 4)]
        [InlineData(3, 4, 5)]

        public void EqualsStack_TwoStacksWithEqualElements_ReturnTrue(int num1, int num2, int num3)
        {
            //Arrange
            var stack1 = new DynamicStack();
            var stack2 = new DynamicStack();
            stack1.Push(num1);
            stack1.Push(num2);
            stack1.Push(num3);
            stack2.Push(num1);
            stack2.Push(num2);
            stack2.Push(num3);

            //Act
            var actual = stack1.EqualsStack(stack2);

            //Assert
            Assert.True(actual);
        }

        [Theory]
        [InlineData(1, 2, 3)]
        [InlineData(2, 3, 4)]
        [InlineData(3, 4, 5)]

        public void EqualsStack_StackTwoFirstElementDifferent_ReturnFalse(int num1, int num2, int num3)
        {
            //Arrange
            var stack1 = new DynamicStack();
            var stack2 = new DynamicStack();
            var differentNum = 0;
            stack1.Push(num1);
            stack1.Push(num2);
            stack1.Push(num3);
            stack2.Push(differentNum);
            stack2.Push(num2);
            stack2.Push(num3);

            //Act
            var actual = stack1.EqualsStack(stack2);

            //Assert
            Assert.False(actual);
        }

        [Theory]
        [InlineData(1, 2, 3)]
        [InlineData(2, 3, 4)]
        [InlineData(3, 4, 5)]

        public void EqualsStack_StackFirstAndFirstElementDifferent_ReturnFalse(int num1, int num2, int num3)
        {
            //Arrange
            var stack1 = new DynamicStack();
            var stack2 = new DynamicStack();
            var differentNum = 0;
            stack1.Push(differentNum);
            stack1.Push(num2);
            stack1.Push(num3);
            stack2.Push(num1);
            stack2.Push(num2);
            stack2.Push(num3);

            //Act
            var actual = stack1.EqualsStack(stack2);

            //Assert
            Assert.False(actual);
        }

        [Theory]
        [InlineData(1, 2, 3)]
        [InlineData(2, 3, 4)]
        [InlineData(3, 4, 5)]

        public void EqualsStack_StackTwoSecondElementDifferent_ReturnFalse(int num1, int num2, int num3)
        {
            //Arrange
            var stack1 = new DynamicStack();
            var stack2 = new DynamicStack();
            var differentNum = 0;
            stack1.Push(num1);
            stack1.Push(num2);
            stack1.Push(num3);
            stack2.Push(num1);
            stack2.Push(differentNum);
            stack2.Push(num3);

            //Act
            var actual = stack1.EqualsStack(stack2);

            //Assert
            Assert.False(actual);
        }

        [Theory]
        [InlineData(1)]
        [InlineData(2)]
        [InlineData(3)]

        public void EqualsStack_BothStacksAreDifferentAtFirstAndSecondElement_ReturnFalse(int num3)
        {
            //Arrange
            var stack1 = new DynamicStack();
            var stack2 = new DynamicStack();
            var differentNum1 = 0;
            var differentNum2 = 9;
            stack1.Push(differentNum2);
            stack1.Push(differentNum2);
            stack1.Push(num3);
            stack2.Push(differentNum1);
            stack2.Push(differentNum1);
            stack2.Push(num3);

            //Act
            var actual = stack1.EqualsStack(stack2);

            //Assert
            Assert.False(actual);
        }
    }
}
