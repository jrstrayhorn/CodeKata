using Xunit;

namespace CodeKata
{
    public class UnitTest1
    {
        private object FizzBuzz(int value)
        {
            var remainderOfFive = value % 5;
            var remainderOfThree = value % 3;
            var isDivisibleByFive = remainderOfFive == 0;
            var isDivisibleByThree = remainderOfThree == 0;
            if (!isDivisibleByFive && !isDivisibleByThree)
                return value;

            return $"{(isDivisibleByThree ? "Fizz" : "")}{(isDivisibleByFive ? "Buzz" : "")}"
                .Trim();
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

        [Fact]
        public void Given1Then1()
        {
            // Arrange
            // Act
            var result = FizzBuzz(1);

            // Assert
            Assert.Equal(1, result);
        }

        [Theory]
        [InlineData(0)]
        [InlineData(15)]
        [InlineData(30)]
        [InlineData(45)]
        public void GivenDivisibleBy3And5ThenFizzBuzz(int number)
        {
            // Arrange
            // Act
            var result = FizzBuzz(number);

            // Assert
            Assert.Equal("FizzBuzz", result);
        }

        [Theory]
        [InlineData(3)]
        [InlineData(6)]
        [InlineData(9)]
        [InlineData(12)]
        public void GivenDivisibleBy3ThenFizz(int number)
        {
            // Arrange
            // Act
            var result = FizzBuzz(number);

            // Assert
            Assert.Equal("Fizz", result);
        }

        [Theory]
        [InlineData(5)]
        [InlineData(10)]
        [InlineData(25)]
        [InlineData(20)]
        public void GivenDivisibleBy5ThenBuzz(int number)
        {
            // Arrange
            // Act
            var result = FizzBuzz(number);

            // Assert
            Assert.Equal("Buzz", result);
        }
    }
}
