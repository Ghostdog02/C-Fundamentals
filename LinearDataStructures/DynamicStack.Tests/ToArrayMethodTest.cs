using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Program.Tests
{
    public class ToArrayMethodTest
    {
        [Theory]
        [InlineData(0, 1, 2)]
        [InlineData(1, 2, 3)]
        [InlineData(2, 3, 4)]

        public void ToArray_StackWithThreeElements_ReturnTrue(int num1, int num2, int num3)
        {
            //Arrange
            var stack = new DynamicStack();
            stack.Push(num1);
            stack.Push(num2);
            stack.Push(num3);

            //Act
            var result = stack.ToArray();

            //Assert
            Assert.True(stack.EqualsArray(result));
            Assert.Equal(stack.Count, result.Length);
        }

        [Fact]

        public void ToArray_EmptyStack_ThrowException()
        {
            //Arrange
            var stack = new DynamicStack();
            
            //Act and Assert
            Assert.Throws<InvalidOperationException>(() => stack.ToArray());
        }
    }
}
