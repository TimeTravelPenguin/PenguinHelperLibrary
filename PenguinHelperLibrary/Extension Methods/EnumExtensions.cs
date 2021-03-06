﻿#region Title Header

// Name: Phillip Smith
// 
// Solution: PenguinHelperLibrary
// Project: PenguinHelperLibrary
// File Name: EnumExtensions.cs
// 
// Current Data:
// 2019-12-30 6:26 PM
// 
// Creation Date:
// 2019-12-21 9:44 PM

#endregion

using System;

namespace PenguinHelperLibrary.Extension_Methods
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
      return (T[]) Enum.GetValues(typeof(T));
    }
  }
}