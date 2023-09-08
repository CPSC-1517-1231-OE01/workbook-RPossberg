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

        private Position _position;
        private Shot _shot;

        // properties

        // constructors
    }
}
