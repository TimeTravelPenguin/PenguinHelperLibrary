#region Title Header

// Name: Phillip Smith
// 
// Solution: PenguinHelperLibrary
// Project: PenguinHelperLibrary
// File Name: ArrayExtensionMethods.cs
// 
// Current Data:
// 2019-12-18 1:06 AM
// 
// Creation Date:
// 2019-12-09 1:02 AM

#endregion

using System;

namespace PenguinHelperLibrary.Extension_Methods
{
    /// <summary>
    ///     Extension methods for <see cref="Array" /> objects
    /// </summary>
    public static class ArrayExtensionMethods
    {
        /// <summary>
        ///     Fills an array with an object or value. If an object, it will be the same reference for each.
        /// </summary>
        /// <typeparam name="T">
        ///     The type of the array
        /// </typeparam>
        /// <param name="arr">
        ///     The array to fill
        /// </param>
        /// <param name="value">
        ///     The value to fill
        /// </param>
        public static void Fill<T>(this T[] arr, T value)
        {
            if (arr is null)
            {
                throw new ArgumentNullException(nameof(arr));
            }

            for (var i = 0; i < arr.Length; i++)
            {
                arr[i] = value;
            }
        }

        /// <summary>
        ///     Fills and array with the default of the array base type.
        /// </summary>
        /// <typeparam name="T">
        ///     The type of the array
        /// </typeparam>
        /// <param name="arr">
        ///     The array to fill
        /// </param>
        public static void FillWithDefault<T>(this T[] arr)
        {
            arr.Fill(default);
        }

        /// <summary>
        ///     Fills an array with an object or value for any null objects in the array.
        ///     If an object, it will be the same reference for each.
        /// </summary>
        /// <typeparam name="T">
        ///     The type of the array
        /// </typeparam>
        /// <param name="arr">
        ///     The array to fill
        /// </param>
        /// <param name="value">
        ///     The value to fill
        /// </param>
        public static void FillNullIndex<T>(this T[] arr, T value)
        {
            if (arr is null)
            {
                throw new ArgumentNullException(nameof(arr));
            }

            for (var i = 0; i < arr.Length; i++)
            {
                if (arr[i] is null)
                {
                    arr[i] = value;
                }
            }
        }
    }
}