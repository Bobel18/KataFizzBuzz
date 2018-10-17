using KataFizzBuzzLib;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;
using static KataFizzBuzzLib.NumberConverter;

namespace KataFizzBuzz.Tests
{
    public class NumberShouldTests
    {

        private void MultipleOfConversion(int input, string expected)
        {
            var multipleOfThreeConverted = NumberConverter.Conversion(input);
            Assert.Contains(multipleOfThreeConverted, expected);

        }

        [Theory]
        [InlineData(3, "Fizz")]
        [InlineData(6, "Fizz")]
        [InlineData(9, "Fizz")]
        [InlineData(12, "Fizz")]
        [InlineData(15, "FizzBuzz")]



        public void ConvertNumberMultipleOfThreeToCharacter(int input, string expected)
            => MultipleOfConversion(input, expected);


        [Theory]

        [InlineData(10, "Buzz")]


        public void ConvertNumberMultipleOfFiveToCharacter(int input, string expected)
            => MultipleOfConversion(input, expected);

        [Theory]

        [InlineData(15, "FizzBuzz")]
        public void ConvertNumberMultipleOfThreeAndFiveToCharacter(int input, string expected)
            => MultipleOfConversion(input, expected);

        [Theory]

        [InlineData(1, "1")]

        public void ConvertNumberToCharacter(int input, string expected)
            => MultipleOfConversion(input, expected);



        [Fact]

        public void ThrowErrorIfInputGreaterThan100()
        {
            var input = 101;
            Action action = () => NumberConverter.Conversion(input);

            Assert.Throws<NumberTooHightException>(action);
        }



        [Fact]

        public void ThrowErrorIfInputIsZero()
        {
            var input = 0;
            Action action = () => NumberConverter.Conversion(input);

            Assert.Throws<ArgumentException>(action);

        }
    }
}
