using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Program.Tests
{
    public class RemoveMethodTest
    {
        [Theory]
        [InlineData(1, 2)]
        [InlineData(2, 3)]
        [InlineData(3, 4)]

        public void Remove_RemoveOneElementFromFirst_ReturnTrue(int num1, int num2)
        {
            //Arrange
            var deque = new Deque(num1);
            deque.AddFirst(num2);

            //Act
            deque.RemoveFirst();

            //Assert
            var stackFirst = deque.First;
            Assert.Equal(1, stackFirst.Count);
            Assert.Equal(1, deque.Count);
            Assert.Equal(num1, stackFirst.Top.Element);
        }

        [Theory]
        [InlineData(1, 2)]
        [InlineData(2, 3)]
        [InlineData(3, 4)]

        public void Remove_RemoveOneElementFromSecond_ReturnTrue(int num1, int num2)
        {
            //Arrange
            var deque = new Deque(num1);
            deque.AddSecond(num2);

            //Act
            deque.RemoveSecond();

            //Assert
            var stackSecond = deque.Second;
            Assert.Equal(1, stackSecond.Count);
            Assert.Equal(1, deque.Count);
            Assert.Equal(num1, stackSecond.Top.Element);
        }

        [Theory]
        [InlineData(1, 2, 3)]
        [InlineData(2, 3, 4)]
        [InlineData(3, 4, 5)]

        public void Remove_RemoveBottomFirst_ReturnTrue(int num1, int num2, int num3)
        {
            //Arrange
            var deque = new Deque(num1);
            deque.AddSecond(num2);
            deque.AddSecond(num3);

            //Act
            deque.RemoveFirst();

            //Assert
            var stackSecond = deque.Second;
            var stackFirst = deque.First;
            Assert.Equal(0, stackFirst.Count);
            Assert.Equal(2, stackSecond.Count);
            Assert.Equal(num3, stackSecond.Top.Element);
            Assert.Equal(2, deque.Count);
        }

        [Theory]
        [InlineData(1, 2, 3)]
        [InlineData(2, 3, 4)]
        [InlineData(3, 4, 5)]

        public void Remove_RemoveBottomSecond_ReturnTrue(int num1, int num2, int num3)
        {
            //Arrange
            var deque = new Deque(num1);
            deque.AddFirst(num2);
            deque.AddFirst(num3);

            //Act
            deque.RemoveSecond();

            //Assert
            var stackSecond = deque.Second;
            var stackFirst = deque.First;
            Assert.Equal(0, stackSecond.Count);
            Assert.Equal(2, stackFirst.Count);
            Assert.Equal(num3, stackFirst.Top.Element);
            Assert.Equal(2, deque.Count);
        }

        [Theory]
        [InlineData(1, 2, 3)]
        [InlineData(2, 3, 4)]
        [InlineData(3, 4, 5)]

        public void Remove_RemoveBottomFromFirstAndSecond_ReturnTrue(int num1, int num2, int num3)
        {
            //Arrange
            var deque = new Deque(num1);

            //Act
            deque.RemoveSecond();

            //Assert
            var stackSecond = deque.Second;
            var stackFirst = deque.First;
            Assert.Equal(0, stackSecond.Count);
            Assert.Equal(0, stackFirst.Count);
            Assert.Equal(0, deque.Count);
        }
    }
}
