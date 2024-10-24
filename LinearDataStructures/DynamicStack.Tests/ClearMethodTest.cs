using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace Program.Tests
{
    public class ClearMethodTest
    {
        [Theory]
        [InlineData(1, 2, 3)]
        [InlineData(4, 5, 6)]
        [InlineData(5, 6, 7)]

        public void Clear_StackWithThreeElements_ReturnTrue(int element1, int element2, int element3)
        {
            //Arrange
            var stack = new DynamicStack();
            stack.Push(element1);
            stack.Push(element2);
            stack.Push(element3);

            //Act
            stack.Clear();

            //Assert
            Assert.Equal(0, stack.Count);
            Assert.Null(stack.Top);
        }

        [Fact]

        public void Clear_EmptyStack_ReturnTrue()
        {
            //Assert
            var stack = new DynamicStack();

            //Act
            stack.Clear();

            //Assert
            Assert.Equal(0, stack.Count);
            Assert.Null(stack.Top);
        }
    }
}
