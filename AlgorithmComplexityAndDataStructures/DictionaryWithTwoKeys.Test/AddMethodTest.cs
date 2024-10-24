using DictionaryWithTwoKeys;
using Newtonsoft.Json.Linq;

namespace Program.Test
{
    public class AddMethodTest
    {
        [Theory]
        [InlineData(1, "a", 1)]
        [InlineData(2, "b", 2)]
        [InlineData(3, "c", 3)]

        public void Add_EmptyDictionary_AddTriplet(int key1, string key2, int value)
        {
            //Arrange
            var dictionary = new BiDictionary<int, string, int>();
            
            //Act
            dictionary.Add(key1, key2, value);

            //Assert
            var actualValueFromKey1 = dictionary.FindByFirstKey(key1);
            var actualValueFromKey2 = dictionary.FindBySecondKey(key2);
            Assert.Equal(value, actualValueFromKey1.First());
            Assert.Equal(value, actualValueFromKey2.First());   
        }

        [Fact]
        public void Add_AddExistingFirstKey_ChainValue()
        {
            //Arrange
            var dictionary = new BiDictionary<int, string, int>();
            int key1 = 1;
            string key2 = "a";
            int value1 = key1;
            int key3 = key1;
            string key4 = "b";
            int value2 = 2;

            //Act
            dictionary.Add(key1, key2, value1);
            dictionary.Add(key3, key4, value2);

            //Assert
            Assert.Equal(value1, dictionary.FindByFirstKey(key1).First());
            Assert.Equal(value2, dictionary.FindByFirstKey(key3)[1]);
            Assert.Equal(value1, dictionary.FindBySecondKey(key2).First());
            Assert.Equal(value2, dictionary.FindBySecondKey(key4).First());
        }

        [Fact]
        public void Add_AddExistingSecondKey_ChainValue()
        {
            //Arrange
            var dictionary = new BiDictionary<int, string, int>();
            int key1 = 1;
            string key2 = "a";
            int value1 = key1;
            int key3 = 2;
            string key4 = "a";
            int value2 = key3;

            //Act
            dictionary.Add(key1, key2, value1);
            dictionary.Add(key3, key4, value2);

            //Assert
            Assert.Equal(value1, dictionary.FindByFirstKey(key1).First());
            Assert.Equal(value2, dictionary.FindByFirstKey(key3).First());
            Assert.Equal(value1, dictionary.FindBySecondKey(key2).First());
            Assert.Equal(value2, dictionary.FindBySecondKey(key4)[1]);
        }

        [Fact]
        public void Add_AddExistingFirstAndSecondKey_ChainValue()
        {
            //Arrange
            var dictionary = new BiDictionary<int, string, int>();
            int key1 = 1;
            string key2 = "a";
            int value1 = key1;
            int key3 = key1;
            string key4 = key2;
            int value2 = 2;

            //Act
            dictionary.Add(key1, key2, value1);
            dictionary.Add(key3, key4, value2);

            //Assert
            Assert.Equal(value1, dictionary.FindByFirstKey(key1).First());
            Assert.Equal(value1, dictionary.FindByFirstKey(key3).First());
            Assert.Equal(value2, dictionary.FindByFirstKey(key3)[1]);
            Assert.Equal(value1, dictionary.FindBySecondKey(key2).First());
            Assert.Equal(value1, dictionary.FindBySecondKey(key4).First());
            Assert.Equal(value2, dictionary.FindBySecondKey(key4)[1]);
        }
    }
}
