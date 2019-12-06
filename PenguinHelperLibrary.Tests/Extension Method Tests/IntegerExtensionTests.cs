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

            [Fact]
            public void AddOrdinal_Throw()
            {
                Invoking(() => GetWithinRange(int.MinValue, 0).AddOrdinal())
                    .Should()
                    .Throw<ArgumentOutOfRangeException>();
            }
        }
    }
}