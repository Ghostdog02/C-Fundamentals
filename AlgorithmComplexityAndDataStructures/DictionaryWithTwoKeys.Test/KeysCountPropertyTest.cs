using DictionaryWithTwoKeys;

namespace Program.Test
{
    public class KeysCountPropertyTest
    {
        [Theory]
        [InlineData(2, 3, 4)]
        [InlineData(3, 4, 5)]
        [InlineData(4, 5, 6)]

        public void KeysCount_DicrionaryWithOnePair_ReturnTwo(int key1, int key2, int value)
        {
            //Arrange
            var dictionary = new BiDictionary<int, int, int>();
            dictionary.Add(key1, key2, value);

            //Act
            var count = dictionary.KeysCount;

            //Assert
            Assert.Equal(2, count);
        }

        [Fact]
        public void KeysCount_DicrionaryWithTwoPairs_ReturnFour()
        {
            //Arrange
            var dictionary = new BiDictionary<int, int, int>();
            dictionary.Add(2, 3, 4);
            dictionary.Add(3, 4, 5);

            //Act
            var count = dictionary.KeysCount;

            //Assert
            Assert.Equal(4, count);
        }
    }
}