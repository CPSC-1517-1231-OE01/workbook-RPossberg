using FluentAssertions;
using Hockey.Data;

namespace Hockey.Test
{
    public class HockeyPlayerTest
    {
        public HockeyPlayer GenerateTestPlayer()

        {
            return new HockeyPlayer();
        }

        [Fact] // This is an attribute
        public void HockeyPlayer_FirstName_ReturnsGoodFirstName()
        {
            //    // Arrange
            //    int a = 1;
            //    int b = 2;
            //    int actual;
            HockeyPlayer player = GenerateTestPlayer();
            const string NAME = "test";
            player.FirstName = NAME; // return new HockeyPlayer();

            //    // Act
            //    actual = a + b;
            string actual = player.FirstName; // return new HockeyPlayer();
            actual.Should().Be("test"); // FluentAssertions


            //    // Assert
            //    actual.Should().Be(3); // FluentAssertions
            actual.Should().Be(NAME);
        } // end of Test1

        [Fact] // This is an attribute

        public void HockeyPlayer_FirstName_ThrowExceptionForEmptyArg()
        {
            // Arrange
            HockeyPlayer player = GenerateTestPlayer();
            const string EMPTY_NAME = "";

            // Act
            Action act = () => player.FirstName = EMPTY_NAME;

            // Assert
            act.Should().Throw<ArgumentException>().WithMessage("First name cannot be null or whitespace.");

        } // end of Test1



        //Arrange
        // int a = 1;
        // int b = 2;
        // int actual;
        // return new HockeyPlayer();

        //Assert
        // Assert.Equal(3, actual); // xUnit
        // actual.Should().Be(3); // FluentAssertions


    } // end of Test1
} // end of class

