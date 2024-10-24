using Program;

namespace FractionTest
{
    public class ParseTest
    {
        [Theory]
        [InlineData("3/4", 3, 4)]
        [InlineData("1/4", 1, 4)]
        [InlineData("7/4", 7, 4)]
        [InlineData("9/4", 9, 4)]

        public void Parse_StringFraction_ReturnFraction(string str, int expectedNumerator, int expectedDenumerator)
        {
            //Arrange
            var fraction = new Fraction();

            //Act
            fraction.Parse(str);

            //Assert
            Assert.Equal((fraction.Numerator, fraction.Denumerator), (expectedNumerator, expectedDenumerator));
        }

    }
}
