#region Title Header

// Name: Phillip Smith
// 
// Solution: PenguinHelperLibrary
// Project: PenguinHelper.Tests
// File Name: DictionaryExtensionTests.cs
// 
// Current Data:
// 2021-07-22 8:24 PM
// 
// Creation Date:
// 2021-07-22 7:20 PM

#endregion

#region usings

using System;
using System.Collections.Generic;
using System.Linq;
using AllOverIt.Fixture;
using FluentAssertions;
using JetBrains.Annotations;
using PenguinHelper.Extensions;
using Xunit;

#endregion

namespace PenguinHelper.Tests.ExtensionTests
{
  /// <summary>
  ///   Tests <see cref="Extensions.DictionaryExtensions" />
  /// </summary>
  [UsedImplicitly]
  public class DictionaryExtensionTests
  {
    /// <summary>
    ///   Tests
    ///   <see
    ///     cref="GetValueOrDefault" />
    /// </summary>
    public class GetValueOrDefault : FixtureBase
    {
      [Fact]
      public void GetValueOrDefault_ThrowsException_NoDefault()
      {
        Invoking(() => DictionaryExtensions.GetValueOrDefault((Dictionary<string, string>) null, Create<string>()))
          .Should()
          .ThrowExactly<ArgumentNullException>();
      }

      [Fact]
      public void GetValueOrDefault_ThrowsException_WithDefault()
      {
        Invoking(() => DictionaryExtensions.GetValueOrDefault(null, Create<string>(), Create<string>()))
          .Should()
          .ThrowExactly<ArgumentNullException>();
      }

      /// <summary>
      ///   Tests successful return of preferred default value of a dictionary, requesting only keys that are not contained.
      /// </summary>
      [Fact]
      public void GetValueOrDefaultTest_Default()
      {
        var defaultVal = Create<string>().ToArray();

        // Keys not to be contained within dictionary
        var randKeys = CreateMany<decimal>(1000).ToArray();

        // Dictionary of keys not containing any keys from randKeys
        var dict = randKeys.ToDictionary(key => CreateExcluding(randKeys),
          value => CreateExcluding(defaultVal));

        // Check for non-existing key. Result should be default value.
        foreach (var key in randKeys)
        {
          DictionaryExtensions.GetValueOrDefault(dict, key, defaultVal[0])
            .Should()
            .Be(defaultVal[0]);
        }
      }

      /// <summary>
      ///   Tests successful return of dictionary value when giving a contained key.
      /// </summary>
      [Fact]
      public void GetValueOrDefaultTest_NoDefault_ContainedKeys()
      {
        var dict = new Dictionary<int, string>();
        dict.AddRange(CreateManyDistinct<KeyValuePair<int, string>>(1000));

        foreach (var keyVal in dict)
        {
          DictionaryExtensions.GetValueOrDefault(dict, keyVal.Key, null)
            .Should()
            .Be(keyVal.Value);
        }
      }

      /// <summary>
      ///   Tests successful return of default dictionary value when giving a non-contained key.
      /// </summary>
      [Fact]
      public void GetValueOrDefaultTest_NoDefault_NonContainedKeys()
      {
        // Keys not to be contained within dictionary
        var randKeys = CreateMany<decimal>(1000).ToArray();

        // Dictionary of keys not containing any keys from randKeys
        var dict = randKeys.ToDictionary(key => CreateExcluding(randKeys), value => Create<string>());

        // Check for non-existing key. Result should be default value.
        foreach (var key in randKeys)
        {
          DictionaryExtensions.GetValueOrDefault(dict, key)
            .Should()
            .Be(default);
        }
      }
    }

    /// <summary>
    ///   Tests
    ///   <see
    ///     cref="AddKeyValuePair" />
    /// </summary>
    public class AddKeyValuePair : FixtureBase
    {
      /// <summary>
      ///   Tests for successful addition of <see cref="System.Collections.Generic.KeyValuePair{TKey,TValue}" /> to
      ///   <see cref="System.Collections.Generic.IDictionary{TKey,TValue}" />, given a collection of
      ///   <see cref="System.Collections.Generic.KeyValuePair{TKey,TValue}" />.
      /// </summary>
      [Fact]
      public void AddKeyValuePairsTest()
      {
        // Create KeyValuePairs
        var keyValPairs = CreateManyDistinct<KeyValuePair<string, string>>(1000);
        var dict = new Dictionary<string, string>();

        // Use extension method to add
        dict.AddRange(keyValPairs);

        foreach (var (key, value) in keyValPairs)
        {
          // Assert that the dictionary contains the Key and correct value
          dict[key]
            .Should()
            .Be(value);
        }
      }

      /// <summary>
      ///   Tests NullArgumentException given a null reference <see cref="System.Collections.Generic.Dictionary{TKey,TValue}" />
      ///   in overloaded method
      /// </summary>
      [Fact]
      public void AddKeyValuePairsTest_Dictionary_NullArgumentException()
      {
        Invoking(() => ((Dictionary<string, string>) null)
            .AddRange(CreateManyDistinct<KeyValuePair<string, string>>()))
          .Should()
          .ThrowExactly<ArgumentNullException>();
      }

      /// <summary>
      ///   Tests for successful addition of <see cref="System.Collections.Generic.KeyValuePair{TKey,TValue}" /> to
      ///   <see cref="System.Collections.Generic.IDictionary{TKey,TValue}" />.
      /// </summary>
      [Fact]
      public void AddKeyValuePairTest()
      {
        // Create KeyValuePairs
        var keyValuePairs = CreateManyDistinct<KeyValuePair<string, string>>(1000);
        var dict = new Dictionary<string, string>();

        // Use extension method to add
        dict.AddRange(keyValuePairs);

        foreach (var (key, value) in keyValuePairs)
        {
          // Assert that the dictionary contains the Key and correct value
          dict[key]
            .Should()
            .Be(value);
        }
      }

      /// <summary>
      ///   Tests NullArgumentException given a null reference <see cref="System.Collections.Generic.Dictionary{TKey,TValue}" />
      /// </summary>
      [Fact]
      public void AddKeyValuePairTest_Dictionary_NullArgumentException()
      {
        Invoking(() => ((Dictionary<string, string>) null).Add(Create<KeyValuePair<string, string>>()))
          .Should()
          .ThrowExactly<ArgumentNullException>();
      }

      /// <summary>
      ///   Tests NullArgumentException given a null reference <see cref="System.Collections.Generic.IEnumerable{T}" />
      /// </summary>
      [Fact]
      public void AddKeyValuePairRangeTest_KeyValuePair_NullArgumentException()
      {
        Invoking(() =>
            new Dictionary<string, string>().AddRange( null))
          .Should()
          .ThrowExactly<ArgumentNullException>();
      }
    }
  }
}