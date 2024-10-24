using Program;
using Xunit;

namespace FractionTest
{
    public class ConstructorTest
    {
        [Theory]
        [InlineData(4, 5)]
        [InlineData(1, 3)]

        public void Fraction_PositiveNumeratorAndPositiveDenumerator_InitializeNumeratorAndDenumerator(int numerator, int denumerator)
        {
            //Arrange and Act
            Fraction fraction = new Fraction(numerator, denumerator);

            //Assert
            Assert.Equal((numerator, denumerator), (fraction.Numerator, fraction.Denumerator));

        }

        [Theory]
        [InlineData(-4, -5)]
        [InlineData(-1, -5)]
        [InlineData(-2, -5)]

        public void Fraction_NegativeNumeratorAndNegativeDenumerator_NormalizeNumeratorAndDenumerator(int numerator,
            int denumerator)
        {
            //Arrange and Act
            Fraction fraction = new Fraction(numerator, denumerator);

            Assert.Equal((-numerator, -denumerator), (fraction.Numerator, fraction.Denumerator));
        }

        [Theory]
        [InlineData(-4, -2, 2)]
        [InlineData(5, -5, -1)]
        [InlineData(4, 2, 2)]

        public void Fraction_numeratorAndDenumeratorAreCommonDivisors_NormalizeNumeratorAndDenumeratorByDividingGCD(int numerator,
            int denumerator, decimal expectedValue)
        {
            //Arrange and Act
            Fraction fraction = new Fraction(numerator, denumerator);

            Assert.Equal(expectedValue, fraction.DecimalValue);
        }

        [Fact]

        public void Fraction_ZeroNumeratorAndZeroDenumerator_ThrowException()
        {
            Assert.Throws<ArgumentException>(() => new Fraction(0, 0));
        }     
    }
}