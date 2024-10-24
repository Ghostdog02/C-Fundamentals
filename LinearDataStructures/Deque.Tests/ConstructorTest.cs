using Program;

namespace Program.Tests
{
    public class ConstructorTest
    {

        [Theory]
        [InlineData(4)]
        [InlineData(5)]
        [InlineData(6)]

        public void Constructor_DequeWithOneElement_InitializeProperties(int num)
        {
            //Act and Arrange
            var deque = new Deque(num);

            //Assert
            var firstStack = deque.First;
            var secondStack = deque.Second;
            Assert.Equal(1, firstStack.Count);
            Assert.Equal(num, firstStack.Top.Element);
            Assert.Equal(1, secondStack.Count);
            Assert.Equal(num, secondStack.Top.Element);
            Assert.Equal(1, deque.Count);
        }
    }
}