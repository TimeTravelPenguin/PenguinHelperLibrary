#region Title Header

// Name: Phillip Smith
// 
// Solution: PenguinHelperLibrary
// Project: PenguinHelperLibrary
// File Name: MathExtensions.cs
// 
// Current Data:
// 2019-12-21 8:51 PM
// 
// Creation Date:
// 2019-12-17 11:41 PM

#endregion

using System;

namespace PenguinHelperLibrary.Extension_Methods
{
    /// <summary>
    ///     Extension methods performing <see cref="Math" /> operations.
    /// </summary>
    public static class MathExtensions
    {
        /// <summary>
        ///     Gets a percentage
        /// </summary>
        /// <param name="lhs"></param>
        /// <param name="rhs"></param>
        /// <returns></returns>
        public static double PercentOf(this double lhs, double rhs)
        {
            return lhs / rhs * 100;
        }
    }
}