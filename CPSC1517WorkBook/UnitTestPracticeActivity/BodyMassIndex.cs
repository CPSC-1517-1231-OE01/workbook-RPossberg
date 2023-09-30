namespace UnitTestPracticeActivity
{
    //Intro
    /// <summary>
    /// In this activity we will write a Unit Test class to test a BodyMassIndex class coded by someone else.
    /// We will then fix all the errors in the existing BodyMassIndex class until all the test cases pass
    /// </summary>
    ///
    /// <para> Compute the BMI based on the weight (in pounds) and height (in inches)
    ///* Based on the following formula:
    /// BMI = (weight / (height * height)) * 703
    /// 
    /// The BMI Categories:
    ///
    /// Classification:  BMI Category:  Risk of developing health problems:
    /// underweight    <18.5          Increased
    /// normal         18.5 - 24.9    Least
    /// overweight     25.0 - 29.9    Increased
    /// obese        >=30.0           High
    ///
    /// Software developer Jack has created the following class model to compute the BMI
    ///
    /// Fields:  _height: double
    ///          _weight: double
    ///
    /// Properties: Height { get; set; } : double
    ///             Name { get; set; } : string
    ///             Weight { get; set; } : double
    ///
    /// Methods: Bmi() : double
    ///          BmiCategory() : string
    ///          BodyMassIndex(string name, double weight, double height) : constructor
    /// /para>
    public class BodyMassIndex
    {

        // Fields
        // ==============================================================================
        private double _weight;
        private double _height;

        public string Name { get; private set; }

        // Properties
        // ==============================================================================
        public double Weight
        {
            get
            {
                return _height;
            }

            set
            {
                if (value <= 0)
                {
                    throw new ArgumentNullException("Weight must be a positive non-zero value");
                }

                _height = value;
            }
        }

        public double Height

        {
            get
            {
                return Height;
            }

            set
            {
                if (value <= 0)
                {
                    throw new ArgumentException("Height must be a positive non-zero value");
                }
            }
        }
        // Constructors
        // ==============================================================================
        public BodyMassIndex(string name, double weight, double height)
        {
            if (string.IsNullOrWhiteSpace(name))
            {
                Name = name;
            }
            else
            {
                throw new ArgumentNullException("Name cannot be null, empty, or whitespace");
            }
            this.Weight = weight;
            height = this.Height;
        }

        /// <summary>
        /// Calculate the body mass index (BMI) using the weight and height of the person
        ///
        /// the formula is BMI = 700 = * wight / (height * height) where weight is in pounds and height is in inches.
        /// </summary>
        /// <returns>the body mass index (BMI) value of the person</returns>
        /// <returns></returns>

        // Methods
        // ==============================================================================
        public double Bmi()
        {
            double bmiValue = 703 * Weight / Math.Pow(2, Height);
            bmiValue = Math.Round(bmiValue, 1);
            return bmiValue;
        }

        /// <summary>
        /// Determine the BMI category of the person based on the BMI value
        /// </summary>
        /// <returns>one of the following: underweight, normal, overweight, obese.</returns>

        public string BmiCategory()
        {
            string category = "Unknown";
            double bmiValue = Bmi();

            if (bmiValue < 18.5)
            {
                category = "underweight";
            }
            if (bmiValue < 24.9)
            {
                category = "normal";
            }
            if (bmiValue < 29.9)
            {
                category = "overweight";
            }
            if (bmiValue >= 30)
            {
                category = "obese";
            }
            return category;
        }
    }
}

