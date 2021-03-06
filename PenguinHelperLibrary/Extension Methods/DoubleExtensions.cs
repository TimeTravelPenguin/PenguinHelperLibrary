﻿#region Title Header

// Name: Phillip Smith
// 
// Solution: PenguinHelperLibrary
// Project: PenguinHelperLibrary
// File Name: DoubleExtensions.cs
// 
// Current Data:
// 2019-12-30 6:26 PM
// 
// Creation Date:
// 2019-12-22 12:53 AM

#endregion

using System;

namespace PenguinHelperLibrary.Extension_Methods
{
  /// <summary>
  ///   Extension methods for type <see cref="double" />
  /// </summary>
  public static class DoubleExtensions
  {
    /// <summary>
    ///   Checks if a <see cref="double" /> value is equal to zero.
    /// </summary>
    /// <param name="value">The <see cref="double" /> value to check if zero.</param>
    /// <returns>
    ///   Returns <see cref="bool" />. If <c>true</c>, the <paramref name="value" /> is equal to zero.
    /// </returns>
    public static bool IsZero(this double value)
    {
      return value.IsEqualTo(0.0);
    }

    /// <summary>
    ///   Compares two <see cref="double" /> values and returns <see langword="true" /> if they are equal.
    /// </summary>
    /// <param name="lhs">The first <see cref="double" /> value.</param>
    /// <param name="rhs">The second <see cref="double" /> value.</param>
    /// <returns>
    ///   Returns <see langword="true" /> if values are equal.
    /// </returns>
    public static bool IsEqualTo(this double lhs, double rhs)
    {
      return Math.Abs(lhs - rhs) < double.Epsilon;
    }

    /// <summary>
    ///   Compares two <see cref="double" /> values and returns <see langword="true" /> if <paramref name="lhs" /> is greater
    ///   than <paramref name="rhs" />.
    /// </summary>
    /// <param name="lhs">The first <see cref="double" /> value.</param>
    /// <param name="rhs">The second <see cref="double" /> value.</param>
    /// <returns>
    ///   Returns <see langword="true" /> if <paramref name="lhs" /> is greater than <paramref name="rhs" />.
    /// </returns>
    public static bool IsGreaterThan(this double lhs, double rhs)
    {
      return lhs - rhs > 0;
    }

    /// <summary>
    ///   Compares two <see cref="double" /> values and returns <see langword="true" /> if <paramref name="lhs" /> is greater
    ///   than or equal to <paramref name="rhs" />.
    /// </summary>
    /// <param name="lhs">The first <see cref="double" /> value.</param>
    /// <param name="rhs">The second <see cref="double" /> value.</param>
    /// <returns>
    ///   Returns <see langword="true" /> if <paramref name="lhs" /> is greater than or equal to <paramref name="rhs" />.
    /// </returns>
    public static bool IsGreaterThanOrEqual(this double lhs, double rhs)
    {
      return lhs.IsGreaterThan(rhs) || lhs.IsEqualTo(rhs);
    }

    /// <summary>
    ///   Checks if a <see cref="double" /> is equal to either <see cref="double.PositiveInfinity" /> or
    ///   <see cref="double.NegativeInfinity" />.
    ///   <para>
    ///   </para>
    ///   This extension method performs: <see cref="double.IsInfinity(double)" />.
    /// </summary>
    /// <param name="value">
    ///   The value to check
    /// </param>
    /// <returns>
    ///   Returns <see cref="bool" /> value
    /// </returns>
    public static bool IsInfinity(this double value)
    {
      return double.IsInfinity(value);
    }

    /// <summary>
    ///   Returns either the minimum or maximum value of a range, if a given value exceeds that range.
    /// </summary>
    /// <param name="value">
    ///   The given value to test is within a range.
    /// </param>
    /// <param name="inclusiveMinimum">
    ///   The minimum value. If <paramref name="value" /> is less than this value, the returned result is
    ///   <paramref name="inclusiveMinimum" />.
    /// </param>
    /// <param name="inclusiveMaximum">
    ///   The minimum value. If <paramref name="value" /> is greater than this value, the returned result is
    ///   <paramref name="inclusiveMaximum" />.
    /// </param>
    /// <returns>
    ///   Returns a <see cref="double" /> value.
    /// </returns>
    public static double LimitToRange(this double value, double inclusiveMinimum, double inclusiveMaximum)
    {
      return Math.Max(Math.Min(value, inclusiveMaximum), inclusiveMinimum);
    }
  }
}