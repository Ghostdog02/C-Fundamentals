using Program;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FractionTest
{
    public class ToStringTest
    {            
        [Theory]
        [InlineData(3, 4, "3/4")]
        [InlineData(1, 4, "1/4")]
        [InlineData(7, 4, "7/4")]
        [InlineData(9, 4, "9/4")]

        public void ToString_PositiveNumeratorAndDenumerator_ReturnStringAsFraction(int numerator, int denumerator, string expected)
        {
            //Arrange
            var fraction = new Fraction(numerator, denumerator);

            //Act
            var str = fraction.ToString();

            //Assert
            Assert.Equal(expected, str);
        }

    }
}
