using Hockey.Data;

namespace Hockey.Data
{
    /// <summary>
    /// an instance of this class will hold data about a hockey player
    /// The code for this class is the definition of that data
    /// The characteristics (data) of the class are:
    ///     first name, last name, birth place, date of birth, height, weight, position, shot
    /// </summary>
    public class HockeyPlayer
    {
        // data fields
        private string _firstName;
        private string _lastName;
        private string _birthPlace;
        private DateOnly _dateOfBirth;
        private int _heightInInches;
        private int _weightInPounds;
        // We don't need to declare the data fields for Position and Shot because they are enums
        private Position _position;
        private Shot _shot;

        // properties

        /// <summary>
        /// Represents the player's birth place
        /// </summary>
        public string BirthPlace 
        {
            get
            {
                return _birthPlace; // return the value of the data field
            }
            set
            {
                if (string.IsNullOrWhiteSpace(value)) // if the value is null or whitespace
                {
                    throw new System.ArgumentException("Birth place cannot be null or whitespace", nameof(value));
                }
                _birthPlace = value; // set the value of the data field
            }
        }

        /// <summary>
        /// Represents the player's height in inches
        /// </summary>
        public int HeightInInches
        {
            get
            {
                return _heightInInches;
            }
            set
            {
                if (value <= 0)
                {
                    throw new System.ArgumentException("Height cannot be negative", nameof(value));
                }
                _heightInInches = value;
            }
        }

        /// <summary>
        /// Represents the player's weight in pounds
        /// </summary>
        public int WeightInPounds
        {
            get
            {
                return _weightInPounds;
            }
            set
            {
                if (value <= 0)
                {
                    throw new System.ArgumentException("Weight cannot be negative", nameof(value));
                }
                _weightInPounds = value;
            }
        }

        /// <summary>
        /// Represents the player's first name
        /// </summary>
        public string FirstName
        {
            get
            {
                return _firstName; // return the value of the data field
            }
            set
            {
                if (string.IsNullOrWhiteSpace(value)) // if the value is null or whitespace
                {
                    throw new System.ArgumentException("First name cannot be null or whitespace", nameof(value));
                }
                _firstName = value; // set the value of the data field
            }
        }

        /// <summary>
        /// Represents the player's last name
        /// </summary>
        public string LastName
        {
            get
            {
                return _lastName; // return the value of the data field
            }
            set
            {
                if (string.IsNullOrWhiteSpace(value)) // if the value is null or whitespace
                {
                    throw new System.ArgumentException("Last name cannot be null or whitespace", nameof(value));
                }
                _lastName = value; // set the value of the data field
            }
        }

        /// <summary>
        /// Represents the player's date of birth
        /// </summary>
        public DateOnly DateOfBirth
        {
            get
            {
                return _dateOfBirth;
            }
            set
            {
                if (value == null)
                {
                    throw new System.ArgumentException("Date of birth cannot be null", nameof(value));
                } else
                {
                       if (value.Year < 1900 || value.Year > DateTime.Now.Day) 
                    {
                        throw new System.ArgumentException("Date of birth cannot be before 1900 or future", nameof(value));
                    }
                }
                _dateOfBirth = value;
            }
        }

        // Auto-implemented properties
        /// <summary>
        /// Represents player's position (left wing, center, right wing, defense, goalie)
        /// </summary>
        public Position Position { get; set; }

        /// <summary>
        /// Represents the player's shot (left or right)
        /// </summary>
        public Shot Shot { get; set; }

        // constructors

        /// <summary>
        /// Creates a new (default) instance of a HockeyPlayer
        /// </summary>
        public HockeyPlayer() 
        {
            // default constructor
            _firstName = string.Empty;
            _lastName = string.Empty;
            _birthPlace = string.Empty;
            _dateOfBirth = new DateOnly(1900, 1, 1);
            _heightInInches = 0;
            _weightInPounds = 0;
            Position = Position.Center;
            Shot = Shot.Left;
        }

        /// <summary>
        /// Creates a new instance of a HockeyPlayer with the specified values
        /// </summary>
        /// <param name="firstName"></param>
        /// <param name="lastName"></param>
        /// <param name="birthPlace"></param>
        /// <param name="dateOfBirth"></param>
        /// <param name="heightInInches"></param>
        /// <param name="weightInPounds"></param>
        /// <param name="position"></param>
        /// <param name="shot"></param>
        public HockeyPlayer(string firstName, string lastName, string birthPlace, DateOnly dateOfBirth, int heightInInches, int weightInPounds, Position position, Shot shot)
        {
            FirstName = firstName;
            LastName = lastName;
            BirthPlace = birthPlace;
            DateOfBirth = dateOfBirth;
            HeightInInches = heightInInches;
            WeightInPounds = weightInPounds;
            Position = position;
            Shot = shot;
        }
    }
}
