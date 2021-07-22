#region Title Header

// Name: Phillip Smith
// 
// Solution: PenguinHelperLibrary
// Project: PenguinHelper
// File Name: MathExtensions.cs
// 
// Current Data:
// 2021-07-22 7:39 PM
// 
// Creation Date:
// 2021-07-22 7:18 PM

#endregion

#region usings

using System;

#endregion

namespace PenguinHelper.Extensions
{
  /// <summary>
  ///   Extension methods performing <see cref="Math" /> operations.
  /// </summary>
  public static class MathExtensions
  {
    /// <summary>
    ///   Gets a percentage
    /// </summary>
    /// <param name="lhs"></param>
    /// <param name="rhs"></param>
    /// <returns>Returns the percentage proportion of the two arguments</returns>
    public static double PercentOf(this double lhs, double rhs)
    {
      return lhs / rhs * 100;
    }
  }
}