#region Title Header

// Name: Phillip Smith
// 
// Solution: PenguinHelperLibrary
// Project: PenguinHelper.Tests
// File Name: EnumExtensionTests.cs
// 
// Current Data:
// 2021-07-22 8:29 PM
// 
// Creation Date:
// 2021-07-22 7:20 PM

#endregion

#region usings

using AllOverIt.Fixture;
using FluentAssertions;
using JetBrains.Annotations;
using PenguinHelper.Extensions;
using Xunit;

#endregion

namespace PenguinHelper.Tests.ExtensionTests
{
  // Used exclusively for testing enums
  internal enum Numbers
  {
    Zero,
    One,
    Two,
    Three,
    Four,
    Five,
    Six,
    Seven,
    Eight,
    Nine,
    Ten
  }

  /// <summary>
  ///   Tests <see cref="EnumExtensions" />
  /// </summary>
  [UsedImplicitly]
  public class EnumExtensionTests
  {
    /// <summary>
    ///   Tests <see cref="EnumExtensions.EnumToArray{T}" />
    /// </summary>
    public class EnumToArrayTests : FixtureBase
    {
      /// <summary>
      ///   Tests that an array is returned with all the appropriate enum values an have the correct type
      /// </summary>
      [Fact]
      public void EnumToArrayTest()
      {
        var index = 0;
        foreach (var number in EnumExtensions.EnumToArray<Numbers>())
        {
          number
            .Should()
            .Be((Numbers) index++)
            .And
            .BeOfType<Numbers>();
        }
      }
    }
  }
}