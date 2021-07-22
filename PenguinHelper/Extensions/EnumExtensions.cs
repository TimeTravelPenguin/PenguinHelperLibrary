#region Title Header

// Name: Phillip Smith
// 
// Solution: PenguinHelperLibrary
// Project: PenguinHelper
// File Name: EnumExtensions.cs
// 
// Current Data:
// 2021-07-22 7:38 PM
// 
// Creation Date:
// 2021-07-22 7:18 PM

#endregion

#region usings

using System;
using System.Linq;

#endregion

namespace PenguinHelper.Extensions
{
  /// <summary>
  ///   Extension methods for type <see cref="Enum" />.
  /// </summary>
  public static class EnumExtensions
  {
    /// <summary>
    ///   Returns an array of type <typeparamref name="T" /> containing <see cref="Enum" /> values.
    /// </summary>
    /// <typeparam name="T">
    ///   The element type of the array
    /// </typeparam>
    /// <returns>
    ///   Returns an array of type <typeparamref name="T" />
    /// </returns>
    public static T[] EnumToArray<T>() where T : Enum
    {
      return Enum.GetValues(typeof(T))
        .Cast<T>()
        .ToArray();
    }
  }
}