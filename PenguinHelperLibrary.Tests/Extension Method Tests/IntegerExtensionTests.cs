#region Title Header

// Name: Phillip Smith
// 
// Solution: PenguinHelperLibrary
// Project: PenguinHelperLibrary.Tests
// File Name: IntegerExtensionTests.cs
// 
// Current Data:
// 2019-12-07 3:52 PM
// 
// Creation Date:
// 2019-12-07 3:06 PM

#endregion

using AllOverIt.Fixture;
using FluentAssertions;
using JetBrains.Annotations;
using PenguinHelperLibrary.Extension_Methods;
using Xunit;

namespace PenguinHelperLibrary.Tests.Extension_Method_Tests
{
    /// <summary>
    ///     Tests <see cref="IntegerExtensions" />
    /// </summary>
    [UsedImplicitly]
    public class IntegerExtensionTests
    {
        /// <summary>
        ///     Tests <see cref="IntegerExtensions.AddOrdinal(int)" />
        /// </summary>
        public class AddOrdinal : AoiFixtureBase
        {
            /// <summary>
            ///     Tests the correct string is returned
            /// </summary>
            /// <param name="input"></param>
            /// <param name="expected"></param>
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