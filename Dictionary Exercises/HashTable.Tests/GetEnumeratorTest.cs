using ImplementHashTable;
using System.Linq;

namespace Program.Tests
{
    public class GetEnumeratorTest
    {
        [Fact]
        public void GetEnumerator_HashTableWithThreePairs_ReturnTrue()
        {
            //Arrange
            var capacity = 3;
            var table = new HashTable<int, int>(capacity);
            table.Add(1, 2);
            table.Add(3, 4);
            table.Add(5, 6);

            //Act
            var enumerator = table.GetEnumerator();

            //Assert
            var count = 0;
            foreach (KeyValuePair<int, int> item in table)
            {
                count++;
            }

            Assert.Equal(3, count);
            enumerator.MoveNext();
            Assert.Equal(new KeyValuePair<int, int>(3, 4), enumerator.Current);
            enumerator.MoveNext();
            Assert.Equal(new KeyValuePair<int, int>(1, 2), enumerator.Current);
            enumerator.MoveNext();
            Assert.Equal(new KeyValuePair<int, int>(5, 6), enumerator.Current);
        }
    }
}
