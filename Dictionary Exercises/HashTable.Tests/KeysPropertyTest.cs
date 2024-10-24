using ImplementHashTable;

namespace Program.Tests
{
    public class KeysPropertyTest
    {
        [Theory]
        [InlineData(1, 2, 3, 4)]
        [InlineData(5, 6, 7, 8)]
        [InlineData(9, 10, 11, 12)]

        public void Keys_HashTableWithTwoKeys_ReturnKeys(int key, int value, int key1, int value1)
        {
            //Arrange
            var capacity = 2;
            var table = new HashTable<int, int>(capacity);
            bool isEqual = true;
            table.Add(key, value);
            table.Add(key1, value1);

            //Act
            var keys = table.Keys;

            //Assert           
            foreach (var item in keys)
            {
                if (table[item] == default(int))
                {
                    isEqual = false;
                    break;
                }
            }

            Assert.True(isEqual);
            Assert.Equal(2, keys.Count());
        }

        [Fact]

        public void Keys_EmptyHashTable_ReturnEmptyCollection()
        {
            //Arrange
            var capacity = 2;
            var table = new HashTable<int, int>(capacity);

            //Act
            var keys = table.Keys;

            //Assert                       
            Assert.Empty(keys);
        }
    }
}
