using New_Calculate;
using System;
using System.Linq;
using Xunit;

namespace NewCalculateTest
{
    public class UnitTest1
    {
        [Theory]
        [InlineData(3, 2, 5)]
        [InlineData(4, 2, 6)]
        [InlineData(10, 20, 30)]

        public void TestSum(double a, double b, double expected)
        {
            SimpleCalculate Calc = new SimpleCalculate();

            double actual = Calc.Sum(a, b);
            Assert.Equal(expected, actual);
        }
        [Theory]
        [InlineData(3, 2, 1)]
        [InlineData(4, 2, 2)]
        [InlineData(20, 10, 10)]

        public void TestMin(double a, double b, double expected)
        {
            SimpleCalculate Calc = new SimpleCalculate();

            double actual = Calc.Min(a, b);
            Assert.Equal(expected, actual);
        }
        [Theory]
        [InlineData(3, 2, 6)]
        [InlineData(4, 2, 8)]
        [InlineData(10, 20, 200)]

        public void TestMult(double a, double b, double expected)
        {
            SimpleCalculate Calc = new SimpleCalculate();

            double actual = Calc.Mult(a, b);
            Assert.Equal(expected, actual);
        }
        [Theory]
        [InlineData(6, 2, 3)]
        [InlineData(4, 2, 2)]
        [InlineData(20, 10, 2)]

        public void Div (double a, double b, double expected)
        {
            SimpleCalculate Calc = new SimpleCalculate();

            double actual = Calc.Div(a, b);
            Assert.Equal(expected, actual);
        }
        [Theory]
        [InlineData(121,11 )]
        [InlineData(144,12)]
        [InlineData(225,15 )]

        public void TestSqrt(double a, double expected)
        {
            SimpleCalculate Calc = new SimpleCalculate();

            double actual = Calc.Sqrt(a);
            Assert.Equal(expected, actual);
        }

    }
}
