using Program;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FractionTest
{
    public class EqualsTest
    {
        [Theory]
        [InlineData(-3, -5, -3, -5)]
        [InlineData(-5, -7, -5, -7)]
        [InlineData(-6, -9, -6, -9)]

        public void Equals_EqualFractions_ReturnTrue(int numerator, int denumerator, int numerator1, int denumerator1)
        {
            //Arrange
            var fraction1 = new Fraction(numerator, denumerator);
            var fraction2 = new Fraction(numerator1, denumerator1);

            //Act
            var isEqual = fraction1.Equals(fraction2);

            //Assert
            Assert.True(isEqual);
        }

        [Theory]
        [InlineData(-3, -5, -4, -5)]
        [InlineData(-5, -7, -9, -7)]
        [InlineData(-6, -9, -9, -9)]

        public void Equals_NotEqualFractions_ReturnFalse(int numerator, int denumerator, int numerator1, int denumerator1)
        {
            //Arrange
            var fraction1 = new Fraction(numerator, denumerator);
            var fraction2 = new Fraction(numerator1, denumerator1);

            //Act
            var isEqual = fraction1.Equals(fraction2);

            //Assert
            Assert.False(isEqual);
        }
    }
}
