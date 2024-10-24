using ImplementHashTable;

namespace Program.Tests
{
    public class ClearMethodTest
    {
        [Fact]

        public void Clear_HashTableWithThreeElements_ClearHashTable()
        {
            //Arrange
            var capacity = 3;
            var table = new HashTable<int, int>(capacity);
            //var capacity = table.Capacity;
            table.Add(1, 2);
            table.Add(3, 4);
            table.Add(4, 5);

            //Act
            table.Clear();

            //Assert
            Assert.Equal(0,table.Count);
            Assert.Equal(capacity, table.Capacity);
            Assert.False(table.ContainsKey(1));
            Assert.False(table.ContainsKey(3));
            Assert.False(table.ContainsKey(5));
        }

        [Fact]

        public void Clear_EmptyHashTable_ReturnSameHashTable()
        {
            //Arrange
            var capacity = 0;
            var table = new HashTable<int, int>(capacity);
            
            //Act
            table.Clear();

            //Assert
            Assert.Equal(0, table.Count);
            Assert.Equal(capacity, table.Capacity);
            Assert.False(table.ContainsKey(1));
            Assert.False(table.ContainsKey(3));
            Assert.False(table.ContainsKey(5));
        }
    }
}
