#region Title Header

// Name: Phillip Smith
// 
// Solution: PenguinHelperLibrary
// Project: PenguinHelperLibrary.Tests
// File Name: RandomExtensionTests.cs
// 
// Current Data:
// 2019-12-18 11:15 AM
// 
// Creation Date:
// 2019-12-18 1:24 AM

#endregion

using System;
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
    ///     Tests <see cref="RandomExtensions" />
    /// </summary>
    [UsedImplicitly]
    public class RandomExtensionTests
    {
        /// <summary>
        ///     Tests <see cref="RandomExtensions.GetRandomIn{T}(System.Collections.Generic.ICollection{T})" />
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
                    collection
                        .Should()
                        .Contain(collection.GetRandomIn());
                }
            }

            /// <summary>
            ///     Tests that <see cref="RandomExtensions.GetRandomIn{T}(System.Collections.Generic.ICollection{T})" /> throws
            ///     <see cref="ArgumentNullException" /> when collection is <see langword="null" />.
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