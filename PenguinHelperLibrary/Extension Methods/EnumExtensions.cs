#region Title Header

// Name: Phillip Smith
// 
// Solution: PenguinHelperLibrary
// Project: PenguinHelperLibrary
// File Name: EnumExtensions.cs
// 
// Current Data:
// 2019-12-07 1:52 PM
// 
// Creation Date:
// 2019-12-07 10:18 AM

#endregion

using System;

namespace PenguinHelperLibrary.Extension_Methods
{
    /// <summary>
    ///     Extension methods for type <see cref="Enum" />.
    /// </summary>
    public static class EnumExtensions
    {
        /// <summary>
        ///     Returns an array of type <typeparamref name="T" /> containing <see cref="Enum" /> values.
        /// </summary>
        /// <typeparam name="T">
        ///     The element type of the array
        /// </typeparam>
        /// <returns>
        ///     Returns an array of type <typeparamref name="T" />
        /// </returns>
        public static T[] EnumToArray<T>() where T : Enum
        {
            return (T[]) Enum.GetValues(typeof(T));
        }
    }
}