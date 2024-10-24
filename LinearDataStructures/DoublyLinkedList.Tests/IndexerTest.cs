using Program;

namespace Program.Tests
{
    public class IndexerTest
    {
        [Theory]
        [InlineData(0)]
        [InlineData(1)]
        [InlineData(2)]

        public void Indexer_NumbersAt0Index_ReturnNumber(int number)
        {
            //Arrange
            DoublyLinkedList list = new DoublyLinkedList();
            list.Add(number);

            //Act and Assert
            Assert.Equal(number, list[0]);
        }

        [Theory]
        [InlineData(0, 3)]
        [InlineData(1, 5)]
        [InlineData(2, 6)]

        public void Indexer_IndexOutOfRange_ThrowException(int number, int index)
        {
            //Arrange
            DoublyLinkedList list = new DoublyLinkedList();
            list.Add(number);

            //Act and Assert
            Assert.Throws<ArgumentOutOfRangeException>(() => list[index]);

        }

    }
}

