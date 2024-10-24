using TreeMultiSetImplementation;

namespace Program.Tests
{
    public class GetEnumeratorMethodTest
    {
        [Theory]
        [InlineData(1, 1, 2)]
        [InlineData(2, 2, 3)]
        [InlineData(3, 3, 4)]

        public void GetEnumerator_SetWithTwoDuplicates_EnumerateEveryElement(int duplicate1, int duplicate2, int num)
        {
            //Arrange
            var set = new TreeMultiSet<int>();
            //var elements = new List<int> { duplicate2, num };
            set.Add(duplicate1);
            set.Add(duplicate2);
            set.Add(num);

            //Act
            var enumerator = set.GetEnumerator();

            //Assert
            enumerator.MoveNext();
            Assert.Equal(duplicate1, enumerator.Current.Key);
            Assert.Equal(duplicate2, enumerator.Current.Value[0]);
            enumerator.MoveNext();
            Assert.Equal(num, enumerator.Current.Key);

        }
    }
}
