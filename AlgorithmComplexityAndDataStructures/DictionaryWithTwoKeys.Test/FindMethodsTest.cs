namespace DictionaryWithTwoKeys.Test
{
    public class FindMethodsTest
    {
        [Theory]
        [InlineData(1,2,3)]
        [InlineData(4,5,6)]
        [InlineData(5,6,7)]

        public void FindByFirstKey_KeyIsPresentInDictionary_ReturnValue(int key1, int key2, int value)
        {
            //Arrange
            var dictionary = new BiDictionary<int, int, int>();
            dictionary.Add(key1, key2, value);

            //Act
            var actual = dictionary.FindByFirstKey(key1);

            //Assert
            Assert.Equal(value, actual.First());
        }

        [Theory]
        [InlineData(1, 2, 3)]
        [InlineData(4, 5, 6)]
        [InlineData(5, 6, 7)]

        public void FindByFirstKey_KeyIsNotPresentInDictionary_ThrowException(int key1, int key2, int value)
        {
            //Arrange
            var dictionary = new BiDictionary<int, int, int>();
            dictionary.Add(key1, key2, value);

            //Act and Assert
            Assert.Throws<KeyNotFoundException>(() => dictionary.FindByFirstKey(0));
        }

        [Theory]
        [InlineData(1, 2, 3)]
        [InlineData(4, 5, 6)]
        [InlineData(5, 6, 7)]

        public void FindBySecondKey_KeyIsPresentInDictionary_ReturnValue(int key1, int key2, int value)
        {
            //Arrange
            var dictionary = new BiDictionary<int, int, int>();
            dictionary.Add(key1, key2, value);

            //Act
            var actual = dictionary.FindByFirstKey(key1);

            //Assert
            Assert.Equal(value, actual.First());
        }

        [Theory]
        [InlineData(1, 2, 3)]
        [InlineData(4, 5, 6)]
        [InlineData(5, 6, 7)]

        public void FindByFirstKey_KeyIsNotPresentInDictionary_ThrowException(int key1, int key2, int value)
        {
            //Arrange
            var dictionary = new BiDictionary<int, int, int>();
            dictionary.Add(key1, key2, value);

            //Act and Assert
            Assert.Throws<KeyNotFoundException>(() => dictionary.FindByFirstKey(0));
        }

        public void CheckIsKeyInDictionary()
        {

        }
    }
}
