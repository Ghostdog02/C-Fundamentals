using Program;

namespace Program.Tests
{
    public class EnqueueMethodTest
    {
        [Theory]
        [InlineData(1, 2, 3)]
        [InlineData(2, 3, 4)]
        [InlineData(3, 4, 5)]

        public void Enqueue_TailBehindHead_ResizeArray(int num1, int num2, int num3)
        {
            //Arrange
            var queue = new CircularQueue<int>();
            queue.HeadIndex = 3;
            queue.Array[queue.HeadIndex] = num1;
            queue.TailIndex = 2;
            queue.Array[queue.TailIndex] = num2;
            queue.Count = 8;

            //Act
            queue.Enqueue(num3);

            //Assert
            Assert.Equal(num1, queue.Array[queue.HeadIndex]);
            Assert.Equal(0, queue.HeadIndex);
            Assert.Equal(num2, queue.Array[queue.TailIndex - 1]);
            Assert.Equal(num3, queue.Array[queue.TailIndex]);
            Assert.Equal(8, queue.TailIndex);
        }

        [Fact]
        public void Enqueue_TailAtEndOfCapacity_ResizeArray()
        {
            //Arrange
            var circularQueue = new CircularQueue<int>();
            var capacity = 16;
            var count = 9;
            var index = 8;

            //Act
            circularQueue.Enqueue(1);
            circularQueue.Enqueue(2);
            circularQueue.Enqueue(3);
            circularQueue.Enqueue(4);
            circularQueue.Enqueue(5);
            circularQueue.Enqueue(6);
            circularQueue.Enqueue(7);
            circularQueue.Enqueue(8);
            circularQueue.Enqueue(9);

            //Assert
            var actualCount = circularQueue.Count;
            var actualCapacity = circularQueue.Capacity;
            Assert.Equal(count, actualCount);
            Assert.Equal(capacity, actualCapacity);
            Assert.Equal(0, circularQueue.HeadIndex);
            Assert.Equal(8, circularQueue.TailIndex);
            Assert.Equal(9, circularQueue.Array[index]);
        }

        [Theory]
        [InlineData(1, 2, 3)]
        [InlineData(2, 3, 4)]
        [InlineData(3, 4, 5)]

        public void Enqueue_HeadIndexDifferentFromZeroTailIndexAtEndOfQueue_ReturnTrue(int num1, int num2, int num3)
        {
            //Arrange
            var queue = new CircularQueue<int>();
            queue.TailIndex = 7;
            queue.Array[queue.TailIndex] = 8;
            queue.HeadIndex = 3;
            queue.Array[queue.HeadIndex] = 4;

            //Act
            queue.Enqueue(num1);
            queue.Enqueue(num2);
            queue.Enqueue(num3);

            //Assert
            Assert.Equal(2, queue.TailIndex);
            Assert.Equal(num1, queue[0]);
            Assert.Equal(num2, queue[1]);
            Assert.Equal(num3, queue[2]);
        }
    }
}