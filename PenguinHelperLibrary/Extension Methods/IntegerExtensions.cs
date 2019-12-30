#region Title Header

// Name: Phillip Smith
// 
// Solution: PenguinHelperLibrary
// Project: PenguinHelperLibrary
// File Name: IntegerExtensions.cs
// 
// Current Data:
// 2019-12-30 6:32 PM
// 
// Creation Date:
// 2019-12-22 12:53 AM

#endregion

using System.Globalization;
using Humanizer;

namespace PenguinHelperLibrary.Extension_Methods
{
  /// <summary>
  ///   Extension methods for type <see cref="int" />
  /// </summary>
  public static class IntegerExtensions
  {
    /// <summary>
    ///   Appends an ordinal to the end of an <see cref="int" /> (1st, 2nd, 3rd, 4th, etc.).
    /// </summary>
    /// <example>
    ///   As an example:
    ///   <br /><c>1.AddOrdinal()</c> returns <c>"1st"</c>
    ///   <br /><c>2.AddOrdinal()</c> returns <c>"2nd"</c>
    ///   <br /><c>3.AddOrdinal()</c> returns <c>"3rd"</c>
    ///   <br /><c>4.AddOrdinal()</c> returns <c>"4th"</c>
    /// </example>
    /// <param name="num">The value to append an ordinal</param>
    /// <param name="cultureInfo"></param>
    /// <returns>
    ///   Returns a <see cref="string" />.
    /// </returns>
    public static string AddOrdinal(this int num, CultureInfo cultureInfo = default)
    {
      return num.Ordinalize(cultureInfo);
    }
  }
}