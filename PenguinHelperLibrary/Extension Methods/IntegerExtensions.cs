using System;

namespace PenguinHelperLibrary.Extension_Methods
{
    /// <summary>
    ///     Extension methods for type <see cref="int" />
    /// </summary>
    public static class IntegerExtensions
    {
        /// <summary>
        ///     Appends an ordinal to the end of an <see cref="int" /> (1st, 2nd, 3rd, 4th, etc.).
        /// </summary>
        /// <example>
        ///     As an example:
        ///     <c>1.AddOrdinal()</c> returns <c>"1st"</c>
        ///     <c>2.AddOrdinal()</c> returns <c>"2nd"</c>
        ///     <c>3.AddOrdinal()</c> returns <c>"3rd"</c>
        ///     <c>4.AddOrdinal()</c> returns <c>"4th"</c>
        /// </example>
        /// <param name="num">The value to append an ordinal</param>
        /// <returns>
        ///     Returns a <see cref="string" />.
        /// </returns>
        /// <exception cref="ArgumentOutOfRangeException">
        ///     Thrown when the <see cref="int" /> value is less than or equal to zero.
        /// </exception>
        public static string AddOrdinal(this int num)
        {
            if (num <= 0)
            {
                throw new ArgumentOutOfRangeException("Value must be greater than zero");
            }

            switch (num % 100)
            {
                case 11:
                case 12:
                case 13:
                    return num + "th";
            }

            switch (num % 10)
            {
                case 1:
                    return num + "st";
                case 2:
                    return num + "nd";
                case 3:
                    return num + "rd";
                default:
                    return num + "th";
            }
        }
    }
}