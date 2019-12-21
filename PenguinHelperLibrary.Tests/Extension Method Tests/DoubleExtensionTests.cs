#region Title Header

// Name: Phillip Smith
// 
// Solution: PenguinHelperLibrary
// Project: PenguinHelperLibrary.Tests
// File Name: DoubleExtensionTests.cs
// 
// Current Data:
// 2019-12-22 12:43 AM
// 
// Creation Date:
// 2019-12-21 9:56 PM

#endregion

using System;
using System.Diagnostics;
using AllOverIt.Fixture;
using FluentAssertions;
using JetBrains.Annotations;
using PenguinHelperLibrary.Extension_Methods;
using Xunit;

namespace PenguinHelperLibrary.Tests.Extension_Method_Tests
{
    /// <summary>
    ///     Tests <see cref="DoubleExtensions" />
    /// </summary>
    [UsedImplicitly]
    public class DoubleExtensionTests
    {
        /// <summary>
        ///     Tests <see cref="DoubleExtensions.IsZero(double)" />
        /// </summary>
        public class IsZero : AoiFixtureBase
        {
            /// <summary>
            ///     Tests that edge cases return false
            /// </summary>
            /// <param name="expected"></param>
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

            /// <summary>
            ///     Tests that non-zero values return false
            /// </summary>
            [Fact]
            public void IsZeroTest_False_Double()
            {
                var expected = CreateExcluding(0d);
                expected.IsZero().Should().BeFalse();
            }

            /// <summary>
            ///     Tests that zero returns true
            /// </summary>
            [Fact]
            public void IsZeroTest_True()
            {
                const double zero = 0;
                zero.IsZero().Should().BeTrue();
            }
        }

        /// <summary>
        ///     Tests <see cref="DoubleExtensions.IsEqualTo(double, double)" />
        /// </summary>
        public class IsEqualTo : AoiFixtureBase
        {
            /// <summary>
            ///     Tests that edge cases return true
            /// </summary>
            /// <param name="expected"></param>
            [Theory]
            [InlineData(double.Epsilon)]
            [InlineData(double.MaxValue)]
            [InlineData(double.MinValue)]
            public void IsEqualTo_True_EdgeCases(double expected)
            {
                expected.IsEqualTo(expected).Should().BeTrue();
            }

            /// <summary>
            ///     Tests that edge cases return false
            /// </summary>
            /// <param name="expected"></param>
            [Theory]
            [InlineData(double.PositiveInfinity)]
            [InlineData(double.NegativeInfinity)]
            [InlineData(double.NaN)]
            public void IsEqualTo_False_EdgeCases(double expected)
            {
                expected.IsEqualTo(expected).Should().BeFalse();
            }

            /// <summary>
            ///     Tests that two un-identical values return false
            /// </summary>
            [Fact]
            public void IsEqualTo_False()
            {
                var lhs = Create<double>();
                var rhs = CreateExcluding(lhs);

                lhs.IsEqualTo(rhs).Should().BeFalse();
            }

            /// <summary>
            ///     Tests that identical values return true
            /// </summary>
            [Fact]
            public void IsEqualTo_True()
            {
                var actual = Create<double>();
                actual.IsEqualTo(actual).Should().BeTrue();
            }
        }

        /// <summary>
        ///     Tests <see cref="DoubleExtensions.IsGreaterThan(double, double)" />
        /// </summary>
        public class IsGreaterThan : AoiFixtureBase
        {
            /// <summary>
            ///     Tests that edge cases return true
            /// </summary>
            /// <param name="lhs"></param>
            /// <param name="rhs"></param>
            [Theory]
            [InlineData(double.Epsilon, 0)]
            [InlineData(0, double.NegativeInfinity)]
            [InlineData(double.PositiveInfinity, 0)]
            public void IsGreaterThan_True_EdgeCases(double lhs, double rhs)
            {
                lhs.IsGreaterThan(rhs).Should().BeTrue();
            }

            /// <summary>
            ///     Tests that edge case return false
            /// </summary>
            /// <param name="lhs"></param>
            /// <param name="rhs"></param>
            [Theory]
            [InlineData(double.NegativeInfinity, double.NegativeInfinity)]
            [InlineData(double.PositiveInfinity, double.PositiveInfinity)]
            [InlineData(double.NaN, double.NaN)]
            public void IsGreaterThan_False_EdgeCases(double lhs, double rhs)
            {
                lhs.IsGreaterThan(rhs).Should().BeFalse();
            }

            /// <summary>
            ///     Tests that if a smaller or equal sized number is not greater than a larger or equal number
            /// </summary>
            [Fact]
            public void IsGreaterThan_False()
            {
                var small = Create<double>();
                var big = small + Math.Abs(CreateExcluding(0));

                small.IsGreaterThan(big).Should().BeFalse();
                small.IsGreaterThan(small).Should().BeFalse();
            }

            /// <summary>
            ///     Tests a bigger number is greater than a smaller number
            /// </summary>
            [Fact]
            public void IsGreaterThan_True()
            {
                var small = Create<double>();
                var big = small + Math.Abs(CreateExcluding(0));

                big.IsGreaterThan(small).Should().BeTrue();
            }
        }

        /// <summary>
        ///     Tests <see cref="DoubleExtensions.IsGreaterThanOrEqual(double, double)" />
        /// </summary>
        public class IsGreaterThanOrEqual : AoiFixtureBase
        {
            /// <summary>
            ///     Tests edge cases return true
            /// </summary>
            /// <param name="lhs"></param>
            /// <param name="rhs"></param>
            [Theory]
            [InlineData(double.Epsilon, 0)]
            [InlineData(double.Epsilon, double.Epsilon)]
            [InlineData(0, double.NegativeInfinity)]
            [InlineData(double.PositiveInfinity, 0)]
            public void IsGreaterThanOrEqual_True_EdgeCases(double lhs, double rhs)
            {
                lhs.IsGreaterThanOrEqual(rhs).Should().BeTrue();
            }

            /// <summary>
            ///     Tests edge cases return false
            /// </summary>
            /// <param name="lhs"></param>
            /// <param name="rhs"></param>
            [Theory]
            [InlineData(double.NegativeInfinity, double.NegativeInfinity)]
            [InlineData(double.PositiveInfinity, double.PositiveInfinity)]
            [InlineData(double.NaN, double.NaN)]
            public void IsGreaterThanOrEqual_False_EdgeCases(double lhs, double rhs)
            {
                lhs.IsGreaterThanOrEqual(rhs).Should().BeFalse();
            }

            /// <summary>
            ///     Tests a smaller number is not greater than or equal to another number
            /// </summary>
            [Fact]
            public void IsGreaterThanOrEqual_False()
            {
                var small = Create<double>();
                var big = small + Math.Abs(CreateExcluding(0));

                small.IsGreaterThanOrEqual(big).Should().BeFalse();
            }

            /// <summary>
            ///     Tests a larger number is greater than or equal to a smaller number
            /// </summary>
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

        /// <summary>
        ///     Tests <see cref="DoubleExtensions.IsInfinity(double)" />.
        /// </summary>
        public class IsInfinityTests : AoiFixtureBase
        {
            /// <summary>
            ///     Test for non numerical inputs
            /// </summary>
            /// <param name="value">
            ///     The number to test is infinity.
            /// </param>
            /// <param name="expected">
            ///     The expected result.
            /// </param>
            [Theory]
            [InlineData(double.PositiveInfinity, true)]
            [InlineData(double.NegativeInfinity, true)]
            [InlineData(double.NaN, false)]
            public void IsInfinityTest_NonNumber(double value, bool expected)
            {
                value.IsInfinity()
                    .Should()
                    .Be(expected);
            }

            /// <summary>
            ///     Tests that a double non-infinity number returns false.
            /// </summary>
            [Fact]
            public void IsInfinityTest_Number()
            {
                Create<double>()
                    .IsInfinity()
                    .Should()
                    .Be(false);
            }
        }

        /// <summary>
        ///     Tests <see cref="DoubleExtensions.LimitToRange(double, double, double)" />.
        /// </summary>
        public class LimitToRangeTests : AoiFixtureBase
        {
            /// <summary>
            ///     Runs tests to check the correct result is returned within the range
            /// </summary>
            [Fact]
            public void LimitToRange()
            {
                for (var i = 0; i < 1000; i++)
                {
                    var value = Create<double>();
                    var min = Create<double>();
                    var max = Create<double>();

                    if (min > max)
                    {
                        var temp = max;
                        max = min;
                        min = temp;
                    }

                    var actual = value.LimitToRange(min, max);

                    Debug.WriteLine($"{min}\t{value}\t{max}\t\t{actual}");

                    if (value <= min)
                    {
                        actual.Should().Be(min);
                    }
                    else if (value >= max)
                    {
                        actual.Should().Be(max);
                    }
                    else
                    {
                        actual.Should().Be(value);
                    }
                }
            }
        }
    }
}