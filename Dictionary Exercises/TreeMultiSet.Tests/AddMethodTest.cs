using TreeMultiSetImplementation;

namespace Program.Tests
{
    public class AddMethodTest
    {
        [Theory]
        [InlineData(1, 1, 2)]
        [InlineData(2, 2, 3)]
        [InlineData(3, 3, 4)]

        public void Add_TwoDuplicateElements_ChainElementInList(int duplicate1, int duplicate2, int num)
        {
            //Arrange
            var set = new TreeMultiSet<int>();

            //Act
            set.Add(duplicate1);
            set.Add(duplicate2);
            set.Add(num);

            //Assert
            Assert.Equal(2, set.FindOccurrences(duplicate1));
            Assert.Equal(2, set.FindOccurrences(duplicate2));
            Assert.Equal(3, set.Count);
            Assert.Equal(1, set.FindOccurrences(num));
        }
    }
}