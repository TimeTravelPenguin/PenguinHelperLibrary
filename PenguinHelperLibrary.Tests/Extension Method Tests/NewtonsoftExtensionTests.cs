#region Title Header

// Name: Phillip Smith
// 
// Solution: PenguinHelperLibrary
// Project: PenguinHelperLibrary.Tests
// File Name: NewtonsoftExtensionTests.cs
// 
// Current Data:
// 2019-12-07 3:55 PM
// 
// Creation Date:
// 2019-12-07 3:06 PM

#endregion

using System;
using AllOverIt.Fixture;
using FluentAssertions;
using JetBrains.Annotations;
using Newtonsoft.Json;
using PenguinHelperLibrary.Extension_Methods;
using Xunit;

namespace PenguinHelperLibrary.Tests.Extension_Method_Tests
{
    /// <summary>
    ///     Tests <see cref="NewtonsoftExtensions" />
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
        ///     Tests <see cref="NewtonsoftExtensions.SerializeObject{T}(T)" />
        /// </summary>
        public class SerializeObjectTests : AoiFixtureBase
        {
            /// <summary>
            ///     Tests that the serialization extension method returns the correct result
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
        ///     Tests <see cref="NewtonsoftExtensions.DeserializeObject{T}(string)" />
        /// </summary>
        public class DeserializeObjectTests : AoiFixtureBase
        {
            /// <summary>
            ///     Tests that the deserialization extension method returns the correct result
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