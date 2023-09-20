using FluentAssertions;
using Utils;

namespace MyUtilitiesTestProject
{
    public class UtilitiesTest
    {
        [Theory]
        [InlineData(1)]
        [InlineData(1.0D)]
        [InlineData("1.0")]
        public void Utilities_IsPositive_ReturnsTrueForPositive(object value)
        {
            // Arrange
            bool actual;
            //int positiveInt = 1;
            //double positiveDouble = 1.0D;
            //decimal positiveDecimal = 1.0M;

            // Act
            if (value.GetType() == typeof(int))
            {
                actual = Utilities.IsPositive(value: (int)value);
            }
            else if (value.GetType() == typeof(double))
            {
                actual = Utilities.IsPositive(value: (double)value);
            }
            else
            {
                actual = Utilities.IsPositive(Convert.ToDecimal(value));
            }

            // Assert
            actual.Should().BeTrue();
        }

        // DateOnly data generator
        public static IEnumerable<object[]> GenerateIsInTheFutureTestData()
        {
            // present
            yield return new object[] { DateOnly.FromDateTime(DateTime.Now), false };
            // future
            yield return new object[] { DateOnly.FromDateTime(DateTime.Now.AddDays(1)), true };
            // past
            yield return new object[] { DateOnly.FromDateTime(DateTime.Now.AddDays(-1)), false };
        }

        [Theory]
        [MemberData(nameof(GenerateIsInTheFutureTestData))]

        public void Utilities_IsInTheFuture_ReturnsTrueForFutureFalseOtherwise(DateOnly value, bool expected)
        {
            // Arrange
            bool actual;
            //DateOnly futureDate = DateOnly.FromDateTime(DateTime.Now.AddDays(1));

            // Act
            actual = Utilities.IsDateInFuture(value);

            // Assert
            actual.Should().Be(expected);
        }


        [Theory]
        [InlineData("")]
        [InlineData(" ")]
        [InlineData(null)]

        public void Utilities_IsNullEmptyOrWhiteSpace_ReturnsTrueForNull(string value)
        {
            // Arrange
            bool actual;
            //bool actualNull;
            //bool actualWhiteSpace;

            //const string EMPTY_STRING = "";
            //const string WHITE_SPACE_STRING = " ";
            //const string NULL_STRING = null;

            // Act
            actual = Utilities.IsNullEmptyOrWhiteSpace(value);

            // Assert
            actual.Should().BeTrue();
        }

        [Fact]
        public void Utilities_IsNullEmptyOrWhiteSpace_ReturnsFalseForNonEmpty()
        {
            // Arrange
            bool actual;
            const string GOOD_STRING = "Hello World";

            // Act
            actual = Utilities.IsNullEmptyOrWhiteSpace(GOOD_STRING);

            // Assert
            actual.Should().BeFalse();
        }
    }
}
