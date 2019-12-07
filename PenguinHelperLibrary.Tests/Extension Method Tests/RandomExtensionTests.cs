#region Title Header

// Name: Phillip Smith
// 
// Solution: PenguinHelperLibrary
// Project: PenguinHelperLibrary.Tests
// File Name: RandomExtensionTests.cs
// 
// Current Data:
// 2019-12-07 1:31 PM
// 
// Creation Date:
// 2019-12-07 12:55 PM

#endregion

using System.Collections.ObjectModel;
using AllOverIt.Fixture;
using AutoFixture;
using FluentAssertions;
using JetBrains.Annotations;
using PenguinHelperLibrary.Extension_Methods;
using Xunit;

namespace PenguinHelperLibrary.Tests.Extension_Method_Tests
{
    /// <summary>
    ///     Tests for the Random Extension Methods
    /// </summary>
    [UsedImplicitly]
    public class RandomExtensionTests
    {
        /// <summary>
        ///     Tests the GetRandomIn method
        /// </summary>
        public class GetRandomInTests : AoiFixtureBase
        {
            /// <summary>
            ///     Tests to ensure items being returned are contained in the collection
            /// </summary>
            [Fact]
            public void GetRandomInTest()
            {
                var collection = new Collection<string>();
                collection.AddMany(Create<string>, 1000);

                for (var i = 0; i < 1000; i++)
                {
                    collection.Should()
                        .Contain(collection.GetRandomIn());
                }
            }
        }
    }
}