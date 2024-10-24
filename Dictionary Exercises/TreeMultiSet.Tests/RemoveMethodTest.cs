using TreeMultiSetImplementation;

namespace Program.Tests
{
    public class RemoveMethodTest
    {
        [Theory]
        [InlineData(1, 1, 2)]
        [InlineData(2, 2, 3)]
        [InlineData(3, 3, 4)]

        public void Remove_DuplicateItems_RemoveAllDuplicates(int duplicate1, int duplicate2, int num)
        {
            //Arrange
            var set = new TreeMultiSet<int>();
            set.Add(duplicate1);
            set.Add(duplicate2);
            set.Add(num);

            //Act
            set.Remove(duplicate1);

            //Assert
            Assert.Equal(1, set.FindOccurrences(num));
        }
    }
}
