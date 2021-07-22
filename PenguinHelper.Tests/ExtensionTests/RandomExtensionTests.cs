#region Title Header

// Name: Phillip Smith
// 
// Solution: PenguinHelperLibrary
// Project: PenguinHelper.Tests
// File Name: RandomExtensionTests.cs
// 
// Current Data:
// 2021-07-22 8:30 PM
// 
// Creation Date:
// 2021-07-22 7:20 PM

#endregion

#region usings

using System;
using System.Collections.ObjectModel;
using AllOverIt.Fixture;
using AutoFixture;
using FluentAssertions;
using JetBrains.Annotations;
using PenguinHelper.Extensions;
using Xunit;

#endregion

namespace PenguinHelper.Tests.ExtensionTests
{
  /// <summary>
  ///   Tests <see cref="RandomExtensions" />
  /// </summary>
  [UsedImplicitly]
  public class RandomExtensionTests
  {
    /// <summary>
    ///   Tests <see cref="RandomExtensions.GetRandomIn{T}(System.Collections.Generic.ICollection{T})" />
    /// </summary>
    public class GetRandomInTests : FixtureBase
    {
      /// <summary>
      ///   Tests to ensure items being returned are contained in the collection
      /// </summary>
      [Fact]
      public void GetRandomInTest()
      {
        var collection = new Collection<string>();
        collection.AddMany(Create<string>, 1000);

        for (var i = 0; i < 1000; i++)
        {
          collection
            .Should()
            .Contain(collection.GetRandomIn());
        }
      }

      /// <summary>
      ///   Tests that <see cref="RandomExtensions.GetRandomIn{T}(System.Collections.Generic.ICollection{T})" /> throws
      ///   <see cref="ArgumentNullException" /> when collection is <see langword="null" />.
      /// </summary>
      [Fact]
      public void TestNullCollection()
      {
        Invoking(() => ((int[]) null).GetRandomIn())
          .Should()
          .ThrowExactly<ArgumentNullException>();
      }
    }
  }
}