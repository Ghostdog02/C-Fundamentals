namespace Program.Tests
{
    public class IndexerTest
    {
        [Theory]
        [InlineData(1)]
        [InlineData(2)]
        [InlineData(3)]

        public void Indexer_GetIndex_ReturnTrue(int num)
        {
            //Arrange
            var queue = new CircularQueue<int>();
            queue.Enqueue(num);

            //Act
            var actual = queue[0];

            //Assert
            Assert.Equal(num, actual);

        }

        [Theory]
        [InlineData(1)]
        [InlineData(2)]
        [InlineData(3)]

        public void Indexer_GetInvalidIndex_ThrowException(int num)
        {
            //Arrange
            var queue = new CircularQueue<int>();
            queue.Enqueue(num);

            //Act and Assert
            Assert.Throws<ArgumentOutOfRangeException>(() => queue[8]);

        }

        [Theory]
        [InlineData(1)]
        [InlineData(2)]
        [InlineData(3)]

        public void Indexer_SetIndex_ReturnTrue(int num)
        {
            //Arrange
            var queue = new CircularQueue<int>();

            //Act
            queue[0] = num;

            //Assert
            Assert.Equal(num, queue[0]);

        }

        [Theory]
        [InlineData(1)]
        [InlineData(2)]
        [InlineData(3)]

        public void Indexer_SetInvalidIndex_ThrowException(int num)
        {
            //Arrange
            var queue = new CircularQueue<int>();
            

            //Act and Assert
            Assert.Throws<ArgumentOutOfRangeException>(() => (queue[8] = 6));

        }
    }
}
