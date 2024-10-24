using TreeMultiSetImplementation;

namespace Program.Tests
{
    public class CompareMethodTest
    {
        [Theory]
        [InlineData(1,1)]
        [InlineData(2,2)]
        [InlineData(3,3)]

        public void Compare_EqualItems_ReturnTrue(int num1, int num2)
        {
            //Arrange
            var set = new TreeMultiSet<int>();
            
            //Act
            int result = set.Compare(num1, num2);

            //Assert
            Assert.Equal(0, result);

        }
    }
}
