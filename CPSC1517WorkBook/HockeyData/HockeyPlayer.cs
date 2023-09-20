using Utils;

namespace Hockey.Data
{
    /// <summary>
    /// An instance of this class will hold data about a hockey player
    /// The code for this class is the definition of that data
    /// The characteristics (data) of the class are:
    ///     first name, last name, birth place, date of birth, height, weight, position, shot
    /// </summary>
    public class HockeyPlayer
    {
        // There are four components to a class:
        // 1. Data (fields)
        // 2. Properties
        // 3. Constructors
        // 4. Methods (functions)

        // data fields
        // are storage areas in the class for data
        // these are treated as variables
        // they may be public, private, or public readonly
        private string _firstName;
        private string _lastName;
        private string _birthPlace;
        private DateOnly _dateOfBirth;
        private int _heightInInches;
        private int _weightInPounds;

        public HockeyPlayer()
        {
        }

        // We don't need to declare the data fields for Position and Shot because they are enums
        // private Position _position = Position.Center;
        // private Shot _shot = Shot.Left;
        //private Position _position;
        //private Shot _shot;

        // Constructor
        // is a method that is called when an instance of the class is created used to initialize an instance of the class.
        // it has the same name as the class
        // The result purpose for implementing a constructor is to ensure that when an instance of the class is created, it is created in a known and valid state. 
        // If a constructor is not implemented, the compiler will create a default constructor that will initialize all data fields to their default values.

        // If your class definition has NO explicit constructors, the compiler will create a default constructor that initializes all data fields to their default values.
        // If your class definition has one or more explicit constructors, the compiler will NOT create a default constructor.
        // If you want a default constructor, you must implement it yourself.
        // If you code a constructor for the class, you are responsible for coding all constructors for the class.
        // (i.e. only the ones you create are valid)
        // If you are going to code your own constructor(s), you will likely code the following two constructors:
        // 1. Default constructor
        // 2. Parameterized (Greedy) constructor - a constructor that accepts a parameter for each data field in the class
        // A parameterized constructor is sometimes referred to as a greedy constructor. This is because it takes one or more  parameters when creating an instance of a class. The parameters are used to set the initial state of the object. The term "greedy" refers to the fact that the constructor requires more information (parameters) at initialization time than other types of constructors.
        //
        // Syntax: access modifier class_name (parameter_list) { code block }
        //
        // IMPORTANT: Constructors do not have a return data type (not even void)
        //            You do not call a constructor directly.
        //            It is called when you create an instance of the class preceded by the "new" operator.
        //            E.g. HockeyPlayer hp = new HockeyPlayer(...);

        // Constructors:
        // Default constructor
        /// <summary>
        /// Creates a new (default) instance of a HockeyPlayer
        /// </summary>
        //public HockeyPlayer()
        //{
        //    // Constructor body:
        //    // a) If empty: the C# compiler will initialize all data fields to their default values
        //    // b) You can provide literal values to initialize the data fields/properties with this constructor

        //    // Ensure that you assign values that would pass any validation rules you have implemented for mutators,
        //    // or better yet, assign to the properties to set the values to make use of validation rules directly - avoids duplication of validation logic in the constructor method(s)

        //    // You may want to code validation logic in the constructor(s) if you have implemented a readonly property or if the data member has only a private set.
        //    _firstName = string.Empty;
        //    _lastName = string.Empty;
        //    _birthPlace = string.Empty;
        //    _dateOfBirth = new DateOnly(1900, 1, 1);
        //    _heightInInches = 0;
        //    _weightInPounds = 0;
        //    Position = Position.Center;
        //    Shot = Shot.Left;
        //}

        // Parameterized constructor (greedy constructor)
        /// <summary>
        /// Creates a new instance of a HockeyPlayer with the specified values (params).
        /// Will throw an exception if any of the params are invalid for the associated property.
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
            // Constructor body:
            // a) A parameter for every property
            // b) You COULD perform validation on the parameters here, but the properties already do it, so just use them.
            // c) Validation for public readonly data members MUST be done here if not done in the property mutator.
            // d) Validation for properties with a private set MUST be don here if not done in the property mutator.
            FirstName = firstName;
            LastName = lastName;
            BirthPlace = birthPlace;
            DateOfBirth = dateOfBirth;
            HeightInInches = heightInInches;
            WeightInPounds = weightInPounds;
            Position = position;
            Shot = shot;
        }

        // Properties 
        // These are access techniques to retrieve and/or modify the data in the class data fields
        // without directly 'touching' the data fields
        // allows for protection of data field

        // A property is associated with a single instance of data
        // A property is public so it can be accessed outside the class
        // A property MUST have a get and/or MAY have a set accessor
        // - if no 'set' is present, the property is readonly, which is commonly used for derived data of the class.
        // - the set can be either public or private
        //      public: user can alter contents of the data field
        //      private: only code within the class can alter contents
        // A property MAY use init in place of a set. The init keyword will ensure that the property can only be set
        // during object initialization. Once the object is initialized, the property can no longer be updated, enforcing immutability.

        // Fully-implemented property
        // a) a declared storage area (data field) for the data
        // b) a declared property signature access type name (get and set).
        // c) a declared (get) method: public accessor that returns the data field
        // d) an optional declared mutator (set) method: public or private accessor that assigns a value to the data field
        //  - if the set is private, it can only be used in a constructor or other method within the class

        // When to use:
        // 1. When you want to validate the data being assigned to the data field (incoming data)
        // 2. If you are storing the data in an explicitly declared data field
        // 3. If you are creating a property that generates output based on other sources within the class (readonly property);
        //    this property would ONLY have an accessor (get).

        /// <summary>
        /// Represents the player's first name
        /// </summary>
        public string FirstName
        {
            get
            {
                // Accessor
                // The get block will return the contents of the associated data field
                // The return has a syntax of return expression
                return _firstName; // return the value of the data field
            }
            private set // init is a new keyword in C# 9.0
            {
                // Mutator
                // The set block will assign a value to the associated data field,
                // receives an incoming "value" and places it into the associated data field
                // During the set, you can perform validation on the incoming data
                // During the set, you may also want to perform some logical processing on the incoming data to set another field.

                // Ensure the incoming value is not null, empty or whitespace (invalid values)
                if (Utilities.IsNullEmptyOrWhiteSpace(value)) // if the value is null or whitespace
                {
                    throw new System.ArgumentException("First name cannot be null or whitespace.");
                }

                // If we get here, the value is valid and we can assign to the data field
                _firstName = value; // set the value of the data field
            }
        } // end of property


        /// <summary>
        /// Represents the player's birth place
        /// </summary>
        public string BirthPlace
        {
            get
            {
                return _birthPlace; // return the value of the data field
            }
            private set
            {
                if (Utilities.IsNullEmptyOrWhiteSpace(value)) // if the value is null or whitespace
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
            private set
            {
                if (Utilities.IsZeroOrNegative(value))
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
            private set
            {
                if (!Utilities.IsPositive(value))
                {
                    throw new System.ArgumentException("Weight cannot be negative");
                }
                _weightInPounds = value;
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
            private set
            {
                if (value == null)
                {
                    throw new System.ArgumentException("Date of birth cannot be null", nameof(value));
                }
                else
                {
                    if (value > DateOnly.FromDateTime(DateTime.Now)) // if the date of birth is in the future
                    {
                        throw new System.ArgumentException("Date of birth cannot be in the future", nameof(value));
                    }
                }
                _dateOfBirth = value;
            }
        }

        // Auto-implemented properties - using an enum so no validation is necessary
        // These properties differ only in syntax from the fully-implemented properties above
        // Each property is responsible for a single piece of data
        // These properties do NOT reference a declared data field
        // The system generates an internal storage area of the return type
        // The compiler will create a data field for the property and manage it for you
        // The system manages the internal storage for the accessor and mutator
        // NOTE: there is NO additional logic applied to the data values

        /// <summary>
        /// Represents player's position (left wing, center, right wing, defense, goalie)
        /// </summary>
        public Position Position { get; set; }

        /// <summary>
        /// Represents the player's shot (left or right)
        /// </summary>
        public Shot Shot { get; set; }

        // Derived property using expression-bodied property
        // https://learn.microsoft.com/en-us/dotnet/csharp/programming-guide/statements-expressions-operators/expression-bodied-members

        /// <summary>
        /// Represents the player's current age 
        /// </summary>
        public int Age => (DateOnly.FromDateTime(DateTime.Now).DayNumber - DateOfBirth.DayNumber) / 365;

        // Behaviours (aka methods)
        // A behaviour is any method in your class
        // Behaviours can be private (for use by the class only) or public (for use by the class and other classes)
        // All rules about methods are in effect for behaviours

        // Behaviours are used to:
        // 1. Perform some action
        // 2. Return a value
        // 3. A combination of 1 and 2

        // A special method may be placed in the class to reflect the data stored by the 
        // instance (object) of the class. This method is called ToString()
        // This method is part of the system software and can be overridden by your own version of the method.


        /// <summary>
        /// Represents the player's last name
        /// </summary>
        public string LastName
        {
            get
            {
                return _lastName; // return the value of the data field
            }
            private set
            {
                if (Utilities.IsNullEmptyOrWhiteSpace(value)) // if the value is null or whitespace
                {
                    throw new System.ArgumentException("Last name cannot be null or whitespace", nameof(value));
                }
                _lastName = value; // set the value of the data field
            }
        } // end of property

        // Override of ToString() method
        // Syntax: access_modifier override return_type method_name (parameter_list) { code block }
        public override string ToString()
        {
            //return base.ToString();
            //return $"{FirstName} {LastName}"; // string interpolation
            return $"{LastName}, {FirstName}"; // string interpolation
        }
    }
}
