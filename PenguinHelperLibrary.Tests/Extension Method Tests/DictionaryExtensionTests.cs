#region Title Header

// Name: Phillip Smith
// 
// Solution: PenguinHelperLibrary
// Project: PenguinHelperLibrary.Tests
// File Name: DictionaryExtensionTests.cs
// 
// Current Data:
// 2019-12-22 12:47 AM
// 
// Creation Date:
// 2019-12-21 9:56 PM

#endregion

using System;
using System.Collections.Generic;
using System.Linq;
using AllOverIt.Fixture;
using FluentAssertions;
using JetBrains.Annotations;
using PenguinHelperLibrary.Extension_Methods;
using Xunit;

namespace PenguinHelperLibrary.Tests.Extension_Method_Tests
{
    /// <summary>
    ///     Tests <see cref="DictionaryExtensions" />
    /// </summary>
    [UsedImplicitly]
    public class DictionaryExtensionTests
    {
        /// <summary>
        ///     Tests
        ///     <see
        ///         cref="PenguinHelperLibrary.Extension_Methods.DictionaryExtensions.GetValueOrDefault{TKey, TValue}(IDictionary{TKey,TValue}, TKey)" />
        /// </summary>
        public class GetValueOrDefault : AoiFixtureBase
        {
            [Fact]
            public void GetValueOrDefault_ThrowsException_NoDefault()
            {
                Invoking(() => ((Dictionary<string, string>) null).GetValueOrDefault(Create<string>()))
                    .Should()
                    .ThrowExactly<ArgumentNullException>();
            }

            [Fact]
            public void GetValueOrDefault_ThrowsException_WithDefault()
            {
                Invoking(
                        () => ((Dictionary<string, string>) null).GetValueOrDefault(Create<string>(), Create<string>()))
                    .Should()
                    .ThrowExactly<ArgumentNullException>();
            }

            /// <summary>
            ///     Tests successful return of preferred default value of a dictionary, requesting only keys that are not contained.
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
                    dict.GetValueOrDefault(key, defaultVal[0])
                        .Should()
                        .Be(defaultVal[0]);
                }
            }

            /// <summary>
            ///     Tests successful return of dictionary value when giving a contained key.
            /// </summary>
            [Fact]
            public void GetValueOrDefaultTest_NoDefault_ContainedKeys()
            {
                var dict = new Dictionary<int, string>();
                dict.AddKeyValuePair(CreateManyDistinct<KeyValuePair<int, string>>(1000).ToArray());

                foreach (var keyVal in dict)
                {
                    dict.GetValueOrDefault(keyVal.Key)
                        .Should()
                        .Be(keyVal.Value);
                }
            }

            /// <summary>
            ///     Tests successful return of default dictionary value when giving a non-contained key.
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
                    dict.GetValueOrDefault(key)
                        .Should()
                        .Be(default);
                }
            }
        }

        /// <summary>
        ///     Tests
        ///     <see
        ///         cref="PenguinHelperLibrary.Extension_Methods.DictionaryExtensions.AddKeyValuePair{TKey, TValue}(IDictionary{TKey, TValue}, IEnumerable{KeyValuePair{TKey, TValue}})" />
        /// </summary>
        public class AddKeyValuePair : AoiFixtureBase
        {
            /// <summary>
            ///     Tests for successful addition of <see cref="KeyValuePair{TKey,TValue}" /> to
            ///     <see cref="IDictionary{TKey,TValue}" />, given a collection of <see cref="KeyValuePair{TKey,TValue}" />.
            /// </summary>
            [Fact]
            public void AddKeyValuePairsTest()
            {
                // Create KeyValuePairs
                var keyValPairs = CreateManyDistinct<KeyValuePair<string, string>>(1000);
                var dict = new Dictionary<string, string>();

                // Use extension method to add
                dict.AddKeyValuePair(keyValPairs);

                foreach (var keyValPair in keyValPairs)
                {
                    // Assert that the dictionary contains the Key and correct value
                    dict[keyValPair.Key]
                        .Should()
                        .Be(keyValPair.Value);
                }
            }

            /// <summary>
            ///     Tests NullArgumentException given a null reference <see cref="Dictionary{TKey,TValue}" /> in overloaded method
            /// </summary>
            [Fact]
            public void AddKeyValuePairsTest_Dictionary_NullArgumentException()
            {
                Invoking(() =>
                        ((Dictionary<string, string>) null).AddKeyValuePair(
                            CreateManyDistinct<KeyValuePair<string, string>>()))
                    .Should()
                    .ThrowExactly<ArgumentNullException>();
            }

            /// <summary>
            ///     Tests for successful addition of <see cref="KeyValuePair{TKey,TValue}" /> to
            ///     <see cref="IDictionary{TKey,TValue}" />.
            /// </summary>
            [Fact]
            public void AddKeyValuePairTest()
            {
                // Create KeyValuePairs
                var keyValPairs = CreateManyDistinct<KeyValuePair<string, string>>(1000);
                var dict = new Dictionary<string, string>();

                // Use extension method to add
                foreach (var keyValuePair in keyValPairs)
                {
                    dict.AddKeyValuePair(keyValuePair);
                }

                foreach (var keyValPair in keyValPairs)
                {
                    // Assert that the dictionary contains the Key and correct value
                    dict[keyValPair.Key]
                        .Should()
                        .Be(keyValPair.Value);
                }
            }

            /// <summary>
            ///     Tests NullArgumentException given a null reference <see cref="Dictionary{TKey,TValue}" />
            /// </summary>
            [Fact]
            public void AddKeyValuePairTest_Dictionary_NullArgumentException()
            {
                Invoking(() =>
                        ((Dictionary<string, string>) null).AddKeyValuePair(Create<KeyValuePair<string, string>>()))
                    .Should()
                    .ThrowExactly<ArgumentNullException>();
            }

            /// <summary>
            ///     Tests NullArgumentException given a null reference <see cref="IEnumerable{T}" />
            /// </summary>
            [Fact]
            public void AddKeyValuePairTest_KeyValuePair_NullArgumentException()
            {
                Invoking(() =>
                        new Dictionary<string, string>().AddKeyValuePair(null))
                    .Should()
                    .ThrowExactly<ArgumentNullException>();
            }
        }
    }
}