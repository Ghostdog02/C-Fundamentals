namespace Program.Tests
{
    public class EqualsArrayMethodTest
    {
        [Theory]
        [InlineData(1, 2, 3)]
        [InlineData(2, 3, 4)]
        [InlineData(3, 4, 5)]

        public void EqualsArray_StackIsEqualToArray_ReturnTrue(int num1, int num2, int num3)
        {
            //Arrange
            var stack = new DynamicStack();
            stack.Push(num1);
            stack.Push(num2);
            stack.Push(num3);
            var array = stack.ToArray();

            //Act
            var actual = stack.EqualsArray(array);

            //Assert
            Assert.True(actual);
        }

        [Theory]
        [InlineData(1, 2, 3)]
        [InlineData(2, 3, 4)]
        [InlineData(3, 4, 5)]

        public void EqualsArray_ArrayThirdElementDifferent_ReturnFalse(int num1, int num2, int num3)
        {
            //Arrange
            var stack = new DynamicStack();
            var differentElement = 0;
            stack.Push(num1);
            stack.Push(num2);
            stack.Push(num3);
            var array = new Node[stack.Count];
            array[0] = new Node(num3);
            array[1] = new Node(num2);
            array[2] = new Node(differentElement);
            array[0].Next = array[1];
            array[1].Next = array[2];

            //Act
            var actual = stack.EqualsArray(array);

            //Assert
            Assert.False(actual);
        }

        [Theory]
        [InlineData(1, 2, 3)]
        [InlineData(2, 3, 4)]
        [InlineData(3, 4, 5)]

        public void EqualsArray_StackSecondElementDifferent_ReturnFalse(int num1, int num2, int num3)
        {
            //Arrange
            var stack = new DynamicStack();
            var differentElement = 0;
            stack.Push(num1);
            stack.Push(differentElement);
            stack.Push(num3);
            var array = new Node[stack.Count];
            array[0] = new Node(num3);
            array[1] = new Node(num2);
            array[2] = new Node(num1);
            array[0].Next = array[1];
            array[1].Next = array[2];

            //Act
            var actual = stack.EqualsArray(array);

            //Assert
            Assert.False(actual);
        }
    }
}
