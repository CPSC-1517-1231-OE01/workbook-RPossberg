namespace Utils
{
    public static class Utilities
    {
        public static bool IsNullEmptyOrWhiteSpace(string value) => string.IsNullOrWhiteSpace(value);
        public static bool IsZeroOrNegative(int value)
        {
            // Simple technique to check if a value is zero or negative
            //return value <= 0; // true | false

            // Explicit technique to check if a value is zero or negative > declare all parts of the condition
            //bool result;

            //if (value <= 0)
            //{
            //    result = true;
            //}
            //else
            //{
            //    result = false;
            //}
            //return result;

            // Simple but explicit -> declare the result variable and assign the result of the condition
            return value <= 0 ? true : false; // true | false 
            //                if(      ) a  else  b ;  

            //bool result;
            //result = value <= 0 ? true : false;
            //return result;
        }

        public static bool IsPositive(int value) => value > 0 ? true : false; // true | false

        public static bool IsPositive(double value) => value > 0.0 ? true : false; // true | false

        public static bool IsPositive(decimal value) => value > 0M ? true : false; // true | false

        // Date Validators
        // ==============================================================================

        /// <summary>
        /// Tests for a DateTime in the future from now
        /// </summary>
        /// <param name="value"></param>
        /// <returns>True if value is in the future or now, false otherwise</returns>
        public static bool IsDateInFuture(DateTime value) => value >= DateTime.Now;

        /// <summary>
        /// Tests for a DateOnly in the future from now
        /// </summary>
        /// <param name="value"></param>
        /// <returns>
        /// True if value is in the future excluding today, false otherwise
        /// </returns>
        public static bool IsDateInFuture(DateOnly value) =>
            value > DateOnly.FromDateTime(DateTime.Now);

    }
}