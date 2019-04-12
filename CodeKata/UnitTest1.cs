using System;
using Xunit;

namespace CodeKata
{
    public class UnitTest1
    {
        private object FizzBuzz(int value)
        {
            if (value == 15)
                return "FizzBuzz";

            return value == 3 ? "Fizz" : "Buzz";
        }

        [Fact]
        public void Given3ThenFizz()
        {
            // Arrange
            // Act
            var result = FizzBuzz(3);

            // Assert
            Assert.Equal("Fizz", result);
        }

        [Fact]
        public void Given5ThenBuzz()
        {
            // Arrange
            // Act
            var result = FizzBuzz(5);

            // Assert
            Assert.Equal("Buzz", result);
        }

        [Fact]
        public void Given15ThenFizzBuzz()
        {
            // Arrange
            // Act
            var result = FizzBuzz(15);

            // Assert
            Assert.Equal("FizzBuzz", result);
        }


    }
}
