using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Program.Tests
{
    public class ContainsMethodTest
    {
        [Theory]
        [InlineData(1, 2, 3, 2)]
        [InlineData(4, 5, 6, 6)]
        [InlineData(7, 8, 9, 8)]

        public void Contains_StackWithThreeElements_ReturnTrue(int num1, int num2, int num3, int numTocheck)
        {
            //Arrange
            var stack = new DynamicStack();
            stack.Push(num1);
            stack.Push(num2);
            stack.Push(num3);

            //Act
            var actual = stack.Contains(numTocheck);

            //Assert
            Assert.True(actual);
        }

        [Theory]
        [InlineData(1, 1)]
        [InlineData(4, 4)]
        [InlineData(7, 7)]

        public void Contains_StackWithOneElements_ReturnTrue(int num1, int numTocheck)
        {
            //Arrange
            var stack = new DynamicStack();
            stack.Push(num1);
            
            //Act
            var actual = stack.Contains(numTocheck);

            //Assert
            Assert.True(actual);
        }

        [Theory]
        [InlineData(1, 2, 3, 4)]
        [InlineData(4, 5, 6, 7)]
        [InlineData(7, 8, 9, 1)]

        public void Contains_StackWithThreeElements_ReturnFalse(int num1, int num2, int num3, int numTocheck)
        {
            //Arrange
            var stack = new DynamicStack();
            stack.Push(num1);
            stack.Push(num2);
            stack.Push(num3);

            //Act
            var actual = stack.Contains(numTocheck);

            //Assert
            Assert.False(actual);
        }

        [Fact]
        
        public void Contains_EmptyStack_ThrowException()
        {
            //Arrange
            var stack = new DynamicStack();
            var num = 0;
            
            //Act and Assert
            Assert.Throws<InvalidOperationException>(() => stack.Contains(num));
        }

        [Fact]

        public void Contains_NullElement_ThrowException()
        {
            //Arrange
            var stack = new DynamicStack();
            var num = 1;
            stack.Push(num);

            //Act and Assert
            Assert.Throws<ArgumentNullException>(() => stack.Contains(null));
        }
    }
}
