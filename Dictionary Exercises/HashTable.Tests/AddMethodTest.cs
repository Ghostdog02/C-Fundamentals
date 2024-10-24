using ImplementHashTable;

namespace Program.Tests
{
    public class AddMethodTest
    {
        [Theory]
        [InlineData(1, 2)]
        [InlineData(3, 4)]
        [InlineData(5, 6)]

        public void Add_KeyIntValueInt_ReturnTrue(int key, int value)
        {
            //Arrange
            var capacity = 1;
            var hashTable = new HashTable<int, int>(capacity);

            //Act
            hashTable.Add(key, value);

            //Assert
            Assert.Equal(value, hashTable[key]);
            Assert.Equal(1, hashTable.Count);
            Assert.Equal(1, hashTable.Capacity);
        }

        [Theory]
        [InlineData(1, 2, 3, 4)]
        [InlineData(3, 4, 5, 6)]
        [InlineData(5, 6, 7, 8)]

        public void Add_AddAtEndOfCapacity_ExpandHashTable(int key, int value, int key1, int value1)
        {
            //Arrange
            var capacity = 1;
            var hashTable = new HashTable<int, int>(capacity);

            //Act
            hashTable.Add(key, value);
            hashTable.Add(key1, value1);

            //Assert
            Assert.Equal(value, hashTable[key]);
            Assert.Equal(value1, hashTable[key1]);
            Assert.Equal(2, hashTable.Count);
            Assert.Equal(2, hashTable.Capacity);
        }

        [Fact]

        public void Add_AddNull_ThrowException()
        {
            //Arrange
            var capacity = 1;
            var hashTable = new HashTable<string, string>(capacity);

            //Act and Assert
            Assert.Throws<ArgumentNullException>(() => hashTable.Add(null, null));
        }
    }
}