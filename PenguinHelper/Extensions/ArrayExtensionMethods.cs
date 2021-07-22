#region Title Header

// Name: Phillip Smith
// 
// Solution: PenguinHelperLibrary
// Project: PenguinHelper
// File Name: ArrayExtensionMethods.cs
// 
// Current Data:
// 2021-07-22 7:25 PM
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
  ///   Extension methods for <see cref="Array" /> objects
  /// </summary>
  public static class ArrayExtensionMethods
  {
    /// <summary>
    ///   Fills an array with an object or value. If an object, it will be the same reference for each.
    /// </summary>
    /// <typeparam name="T">
    ///   The type of the array
    /// </typeparam>
    /// <param name="arr">
    ///   The array to fill
    /// </param>
    /// <param name="value">
    ///   The value to fill
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
    ///   Fills an array with an object of value, given a function to generate the object or value.
    /// </summary>
    /// <typeparam name="T">
    ///   The type of array.
    /// </typeparam>
    /// <param name="arr">
    ///   The array to fill.
    /// </param>
    /// <param name="generatorFunc">
    ///   The generating function to use to fill the array.
    /// </param>
    public static void Fill<T>(this T[] arr, Func<T> generatorFunc)
    {
      if (arr is null)
      {
        throw new ArgumentNullException(nameof(arr));
      }

      for (var i = 0; i < arr.Length; i++)
      {
        arr[i] = generatorFunc.Invoke();
      }
    }

    /// <summary>
    ///   Fills and array with the default of the array base type.
    /// </summary>
    /// <typeparam name="T">
    ///   The type of the array
    /// </typeparam>
    /// <param name="arr">
    ///   The array to fill
    /// </param>
    public static void FillWithDefault<T>(this T[] arr)
    {
      arr.Fill(default(T));
    }

    /// <summary>
    ///   Fills an array with an object or value for any null objects in the array.
    ///   If an object, it will be the same reference for each.
    /// </summary>
    /// <typeparam name="T">
    ///   The type of the array
    /// </typeparam>
    /// <param name="arr">
    ///   The array to fill
    /// </param>
    /// <param name="value">
    ///   The value to fill
    /// </param>
    public static void ReplaceNull<T>(this T[] arr, T value)
    {
      if (arr is null)
      {
        throw new ArgumentNullException(nameof(arr));
      }

      for (var i = 0; i < arr.Length; i++)
      {
        arr[i] ??= value;
      }
    }
  }
}