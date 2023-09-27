using FluentAssertions;
using Hockey.Data;
using System.Collections;

namespace Hockey.Test
{
    public class HockeyPlayerTest
    {
        // Constants for a test player
        const string FirstName = "Conner";
        const string LastName = "Brown";
        const string BirthPlace = "Toronto, ON, CAN";
        const int HeightInInches = 72;
        const int WeightInPounds = 188;
        const int JerseyNumber = 28;
        const Position PlayerPosition = Position.Center;
        const Shot PlayerShot = Shot.Left;
        // The following relies on our being correct here - not writing a test for the test expected value
        static readonly DateOnly DateOfBirth = new DateOnly(1994, 01, 14);
        const string ToStringValue = $"{FirstName} {LastName}";
        readonly int Age = (DateOnly.FromDateTime(DateTime.Now).DayNumber - DateOfBirth.DayNumber) / 365;

        //! [Fact]
        //public void Age_IsCorrect()
        //{
        //    Age.Should().Be(29);
        //TODO: Fix this test

        public HockeyPlayer CreateTestHockeyPlayer()
        {
            return new HockeyPlayer(FirstName, LastName, BirthPlace, DateOfBirth, HeightInInches, WeightInPounds, JerseyNumber, PlayerPosition, PlayerShot);
        }


        // Test data generator for class data
        private class BadHockeyPlayerTestDataGenerator : IEnumerable<object[]>
        {
            private readonly List<object[]> _data = new List<object[]>
            {
                // First Name tests
                new object[]{"", LastName, BirthPlace, DateOfBirth, HeightInInches, WeightInPounds, JerseyNumber, PlayerPosition, PlayerShot, "First name cannot be null or empty." },
                new object[]{" ", LastName, BirthPlace, DateOfBirth, HeightInInches, WeightInPounds, JerseyNumber, PlayerPosition, PlayerShot, "First name cannot be null or empty." },
                new object[]{null, LastName, BirthPlace, DateOfBirth, HeightInInches, WeightInPounds, JerseyNumber, PlayerPosition, PlayerShot, "First name cannot be null or empty." },

                // TODO: complete remaining private set tests
            };

            public IEnumerator<object[]> GetEnumerator() => _data.GetEnumerator();

            IEnumerator IEnumerable.GetEnumerator() => GetEnumerator();
        }

        // valid jersey number 1 - 98
        [Theory]
        [InlineData(1)]
        [InlineData(98)]
        public void HockeyPlayer_JerseyNumber_GoodSetAndGet(int value)
        {
            HockeyPlayer player = CreateTestHockeyPlayer();
            int actual;

            player.JerseyNumber = value;
            actual = player.JerseyNumber;

            actual.Should().Be(value);
        }

        // invalid jersey number < 1 || > 98
        [Theory]
        [InlineData(0)]
        [InlineData(99)]
        public void HockeyPlayer_JerseyNumber_BadSet(int value)
        {
            HockeyPlayer player = CreateTestHockeyPlayer();

            Action act = () => player.JerseyNumber = value;

            act.Should().Throw<ArgumentOutOfRangeException>().WithMessage("Jersey Number must be between 1 and 98");
        }

        [Fact]
        public void HockeyPlayer_Age_ReturnsCorrectValue()
        {
            HockeyPlayer player = CreateTestHockeyPlayer();
            int actual;

            actual = player.Age;

            actual.Should().Be(Age);
        }

        [Fact]

        public void HockeyPlayer_ToString_ReturnsCorrectValue()
        {
            HockeyPlayer player = CreateTestHockeyPlayer();
            string actual;

            actual = player.ToString();

            actual.Should().Be(ToStringValue);
        }

    } // end of Test1
} // end of class

