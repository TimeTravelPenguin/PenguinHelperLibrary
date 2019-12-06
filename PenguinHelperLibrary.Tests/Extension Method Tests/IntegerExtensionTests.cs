#region Title Header

// Name: Phillip Smith
// 
// Solution: PenguinHelperLibrary
// Project: PenguinHelperLibrary.Tests
// File Name: IntegerExtensionTests.cs
// 
// Current Data:
// 2019-12-07 1:10 AM
// 
// Creation Date:
// 2019-12-06 7:22 PM

#endregion

using System;
using AllOverIt.Fixture;
using FluentAssertions;
using PenguinHelperLibrary.Extension_Methods;
using Xunit;

namespace PenguinHelperLibrary.Tests.Extension_Method_Tests
{
    public class IntegerExtensionTests
    {
        public class AddOrdinal : AoiFixtureBase
        {
            [Theory]
            [InlineData(1, "1st")]
            [InlineData(2, "2nd")]
            [InlineData(3, "3rd")]
            [InlineData(4, "4th")]
            public void AddOrdinalTest(int input, string expected)
            {
                input.AddOrdinal().Should().Be(expected);
            }
        }
    }
}