namespace Program.Tests
{
    public class DequeueMethodTest
    {
        [Theory]
        [InlineData(1)]
        [InlineData(2)]
        [InlineData(3)]

        public void Dequeue_StackWithOneElement_ReturnTrue(int num)
        {
            //Arrange
            var queue = new CircularQueue<int>();
            queue.Enqueue(num);

            //Act
            var actual = queue.Dequeue();

            //Assert
            Assert.Equal(num, actual);
            Assert.Equal(0, queue.Count);
            Assert.Equal(0, queue.HeadIndex);
            Assert.Equal(0, queue.TailIndex);
            Assert.Equal(0, queue[0]);
        }

        [Theory]
        [InlineData(1, 2, 3)]
        [InlineData(2, 3, 4)]
        [InlineData(3, 4, 5)]

        public void Dequeue_StackWithThreeElements_ReturnTrue(int num1, int num2, int num3)
        {
            //Arrange
            var queue = new CircularQueue<int>();
            queue.Enqueue(num1);
            queue.Enqueue(num2);
            queue.Enqueue(num3);

            //Act
            queue.Dequeue();

            //Assert
            Assert.Equal(2, queue.Count);
            Assert.Equal(num2, queue[queue.HeadIndex]);
            Assert.Equal(1, queue.HeadIndex);
            Assert.Equal(2, queue.TailIndex);
        }

        [Theory]
        [InlineData(1, 2, 3)]
        [InlineData(2, 3, 4)]
        [InlineData(3, 4, 5)]

        public void Dequeue_HeadIndexAtEndOfCapacity_ReturnTrue(int num1, int num2, int num3)
        {
            //Arrange
            var queue = new CircularQueue<int>();
            queue.HeadIndex = 7;
            queue.TailIndex = 1;
            queue.Count = 7;
            queue[7] = num1;
            queue[0] = num2;
            queue[1] = num3;

            //Act
            queue.Dequeue();
            queue.Dequeue();

            //Assert
            Assert.Equal(0, queue[7]);
            Assert.Equal(0, queue[0]);
            Assert.Equal(queue.TailIndex, queue.HeadIndex);

        }
    }
}
