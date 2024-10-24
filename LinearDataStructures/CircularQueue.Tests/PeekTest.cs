namespace Program.Tests
{
    public class PeekTest
    {
        [Theory]
        [InlineData(1)]
        [InlineData(2)]
        [InlineData(3)]

        public void Peek_QueueWithOneItem_ReturnTrue(int num)
        {
            //Arrange
            var queue = new CircularQueue<int>();
            queue.Enqueue(num);

            //Act
            var actual = queue.Peek();

            //Assert
            Assert.Equal(num, actual);
        }

        [Theory]
        [InlineData(1, 2, 3)]
        [InlineData(2, 3, 4)]
        [InlineData(3, 4, 5)]

        public void Peek_HeadIndexTwo_ReturnTrue(int num1, int num2, int num3)
        {
            //Arrange
            var queue = new CircularQueue<int>();
            queue.Enqueue(num1);
            queue.Enqueue(num2);
            queue.Enqueue(num3);
            queue.Dequeue();

            //Act
            var actual = queue.Peek();

            //Assert
            Assert.Equal(num2, actual);
        }
    }
}
