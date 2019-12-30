#region Title Header

// Name: Phillip Smith
// 
// Solution: PenguinHelperLibrary
// Project: PenguinHelperLibrary
// File Name: MathExtensions.cs
// 
// Current Data:
// 2019-12-30 6:32 PM
// 
// Creation Date:
// 2019-12-22 12:53 AM

#endregion

using System;

namespace PenguinHelperLibrary.Extension_Methods
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
    /// <returns></returns>
    public static double PercentOf(this double lhs, double rhs)
    {
      return lhs / rhs * 100;
    }
  }
}