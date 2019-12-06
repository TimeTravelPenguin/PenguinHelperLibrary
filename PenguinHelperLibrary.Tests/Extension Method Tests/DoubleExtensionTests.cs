#region Title Header

// Name: Phillip Smith
// 
// Solution: PenguinHelperLibrary
// Project: PenguinHelperLibrary.Tests
// File Name: DoubleExtensionTests.cs
// 
// Current Data:
// 2019-12-07 1:10 AM
// 
// Creation Date:
// 2019-12-06 4:14 PM

#endregion

using System;
using AllOverIt.Fixture;
using FluentAssertions;
using JetBrains.Annotations;
using PenguinHelperLibrary.Extension_Methods;
using Xunit;

namespace PenguinHelperLibrary.Tests.Extension_Method_Tests
{
    [UsedImplicitly]
    public class DoubleExtensionTests
    {
        public class IsZero : AoiFixtureBase
        {
            [Theory]
            [InlineData(double.Epsilon)]
            [InlineData(double.MinValue)]
            [InlineData(double.MaxValue)]
            [InlineData(double.PositiveInfinity)]
            [InlineData(double.NegativeInfinity)]
            [InlineData(double.NaN)]
            public void IsZeroTest_False_EdgeCases(double expected)
            {
                expected.IsZero().Should().BeFalse();
            }

            [Fact]
            public void IsZeroTest_False_Double()
            {
                var expected = CreateExcluding(0d);
                expected.IsZero().Should().BeFalse();
            }

            [Fact]
            public void IsZeroTest_True()
            {
                const double zero = 0;
                zero.IsZero().Should().BeTrue();
            }
        }

        public class IsEqualTo : AoiFixtureBase
        {
            [Theory]
            [InlineData(double.Epsilon)]
            [InlineData(double.MaxValue)]
            [InlineData(double.MinValue)]
            public void IsEqualTo_True_EdgeCases(double expected)
            {
                expected.IsEqualTo(expected).Should().BeTrue();
            }

            [Theory]
            [InlineData(double.PositiveInfinity)]
            [InlineData(double.NegativeInfinity)]
            [InlineData(double.NaN)]
            public void IsEqualTo_False_EdgeCases(double expected)
            {
                expected.IsEqualTo(expected).Should().BeFalse();
            }

            [Fact]
            public void IsEqualTo_False()
            {
                var lhs = Create<double>();
                var rhs = CreateExcluding(lhs);

                lhs.IsEqualTo(rhs).Should().BeFalse();
            }

            [Fact]
            public void IsEqualTo_True()
            {
                var actual = Create<double>();
                actual.IsEqualTo(actual).Should().BeTrue();
            }
        }

        public class IsGreaterThan : AoiFixtureBase
        {
            [Theory]
            [InlineData(double.Epsilon, 0, true)]
            [InlineData(0, double.NegativeInfinity, true)]
            [InlineData(double.PositiveInfinity, 0, true)]
            public void IsGreaterThan_True_EdgeCases(double lhs, double rhs, bool expected)
            {
                lhs.IsGreaterThan(rhs).Should().Be(expected);
            }

            [Theory]
            [InlineData(double.NegativeInfinity, double.NegativeInfinity, false)]
            [InlineData(double.PositiveInfinity, double.PositiveInfinity, false)]
            [InlineData(double.NaN, double.NaN, false)]
            public void IsGreaterThan_False_EdgeCases(double lhs, double rhs, bool expected)
            {
                lhs.IsGreaterThan(rhs).Should().Be(expected);
            }

            [Fact]
            public void IsGreaterThan_False()
            {
                var small = Create<double>();
                var big = small + Math.Abs(CreateExcluding(0));

                small.IsGreaterThan(big).Should().BeFalse();
            }

            [Fact]
            public void IsGreaterThan_True()
            {
                var small = Create<double>();
                var big = small + Math.Abs(CreateExcluding(0));

                big.IsGreaterThan(small).Should().BeTrue();
            }
        }

        public class IsGreaterThanOrEqual : AoiFixtureBase
        {
            [Theory]
            [InlineData(double.Epsilon, 0, true)]
            [InlineData(double.Epsilon, double.Epsilon, true)]
            [InlineData(0, double.NegativeInfinity, true)]
            [InlineData(double.PositiveInfinity, 0, true)]
            public void IsGreaterThanOrEqual_True_EdgeCases(double lhs, double rhs, bool expected)
            {
                lhs.IsGreaterThanOrEqual(rhs).Should().Be(expected);
            }

            [Theory]
            [InlineData(double.NegativeInfinity, double.NegativeInfinity, false)]
            [InlineData(double.PositiveInfinity, double.PositiveInfinity, false)]
            [InlineData(double.NaN, double.NaN, false)]
            public void IsGreaterThanOrEqual_False_EdgeCases(double lhs, double rhs, bool expected)
            {
                lhs.IsGreaterThanOrEqual(rhs).Should().Be(expected);
            }

            [Fact]
            public void IsGreaterThanOrEqual_False()
            {
                var small = Create<double>();
                var big = small + Math.Abs(CreateExcluding(0));

                small.IsGreaterThanOrEqual(big).Should().BeFalse();
            }

            [Fact]
            public void IsGreaterThanOrEqual_True()
            {
                var small = Create<double>();
                var big = small + Math.Abs(CreateExcluding(0));

                big.IsGreaterThanOrEqual(small).Should().BeTrue();
                small.IsGreaterThanOrEqual(small).Should().BeTrue();
                big.IsGreaterThanOrEqual(big).Should().BeTrue();
            }
        }
    }
}