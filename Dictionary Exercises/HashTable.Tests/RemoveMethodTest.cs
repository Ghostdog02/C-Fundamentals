using ImplementHashTable;

namespace Program.Tests
{
    public class RemoveMethodTest
    {
        [Theory]
        [InlineData(1)]
        [InlineData(3)]
        [InlineData(5)]

        public void Remove_HashTableWithThreePairs_RemoveFirstPair(int key)
        {
            //Arrange
            var capacity = 3;
            var table = new HashTable<int, int>(capacity);
            table.Add(1, 2);
            table.Add(3, 4);
            table.Add(5, 6);

            //Act
            bool isRemoved = table.Remove(key);

            //Assert
            Assert.True(isRemoved);
            Assert.Equal(2, table.Count);
            Assert.Equal(0, table[key]);
        }

        [Theory]
        [InlineData(2)]
        [InlineData(6)]
        [InlineData(7)]

        public void Remove_HashTableWithThreePairsNoMatches_ReturnSameHashTable(int key)
        {
            //Arrange
            var capacity = 3;
            var table = new HashTable<int, int>(capacity);
            table.Add(1, 2);
            table.Add(3, 4);
            table.Add(5, 6);

            //Act
            bool isRemoved = table.Remove(key);

            //Assert
            Assert.False(isRemoved);
            Assert.Equal(3, table.Count);
            
        }

        [Theory]
        [InlineData(2)]
        [InlineData(6)]
        [InlineData(7)]

        public void Remove_EmptyHashTable_ReturnSameHashTable(int key)
        {
            //Arrange
            var capacity = 3;
            var table = new HashTable<int, int>(capacity);

            //Act
            bool isRemoved = table.Remove(key);

            //Assert
            Assert.False(isRemoved);
            Assert.Equal(0, table.Count);

        }
    }
}
