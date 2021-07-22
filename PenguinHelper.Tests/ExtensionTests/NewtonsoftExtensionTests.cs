#region Title Header

// Name: Phillip Smith
// 
// Solution: PenguinHelperLibrary
// Project: PenguinHelper.Tests
// File Name: NewtonsoftExtensionTests.cs
// 
// Current Data:
// 2021-07-22 8:30 PM
// 
// Creation Date:
// 2021-07-22 7:20 PM

#endregion

#region usings

using System;
using AllOverIt.Fixture;
using FluentAssertions;
using JetBrains.Annotations;
using Newtonsoft.Json;
using PenguinHelper.Newtonsoft.Extensions;
using Xunit;

#endregion

namespace PenguinHelper.Tests.ExtensionTests
{
  /// <summary>
  ///   Tests <see cref="NewtonsoftExtensions" />
  /// </summary>
  [UsedImplicitly]
  public class NewtonsoftExtensionTests
  {
    // Object used to test serialization
    [UsedImplicitly]
    internal class RandomObject
    {
      public string RandomString { get; set; }
      public int RandomInt { get; set; }
      public double RandomDouble { get; set; }
      public DateTime RandomDateTime { get; set; }
    }

    /// <summary>
    ///   Tests <see cref="NewtonsoftExtensions.SerializeObject{T}(T)" />
    /// </summary>
    public class SerializeObjectTests : FixtureBase
    {
      /// <summary>
      ///   Tests that the serialization extension method returns the correct result
      /// </summary>
      [Fact]
      public void SerializeObjectTest()
      {
        var randomObject = Create<RandomObject>();

        randomObject.SerializeObject()
          .Should()
          .Be(JsonConvert.SerializeObject(randomObject));
      }
    }

    /// <summary>
    ///   Tests <see cref="NewtonsoftExtensions.DeserializeObject{T}(string)" />
    /// </summary>
    public class DeserializeObjectTests : FixtureBase
    {
      /// <summary>
      ///   Tests that the deserialization extension method returns the correct result
      /// </summary>
      [Fact]
      public void DeserializeObjectTest()
      {
        var randomSerialization = JsonConvert.SerializeObject(Create<RandomObject>());

        randomSerialization.DeserializeObject<RandomObject>()
          .Should()
          .BeEquivalentTo(JsonConvert.DeserializeObject<RandomObject>(randomSerialization));
      }
    }
  }
}