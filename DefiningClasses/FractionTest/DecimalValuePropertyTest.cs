using Program;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FractionTest
{
    public class DecimalValuePropertyTest
    {
        [Theory]
        [InlineData(-4, -5, 0.8)]
        [InlineData(-1, -5, 0.2)]
        [InlineData(-2, -5, 0.4)]

        public void DecimalValue_NegativeNumeratorAndNegativeDenumerator_ReturnDecimalValueOfFraction(int numerator,
            int denumerator, decimal expectedValue)
        {
            //Arrange 
            Fraction fraction = new Fraction(numerator, denumerator);

            //Act
            decimal decimalValue = fraction.DecimalValue;

            //Assert
            Assert.Equal(expectedValue, decimalValue);
        }    
    }
}
