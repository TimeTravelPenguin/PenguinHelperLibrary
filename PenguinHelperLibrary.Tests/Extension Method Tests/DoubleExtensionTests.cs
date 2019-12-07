#region Title Header

// Name: Phillip Smith
// 
// Solution: PenguinHelperLibrary
// Project: PenguinHelperLibrary.Tests
// File Name: DoubleExtensionTests.cs
// 
// Current Data:
// 2019-12-07 3:57 PM
// 
// Creation Date:
// 2019-12-07 3:06 PM

#endregion

using System;
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
        ///     Tests <see cref="IsZero" />
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
        ///     Tests <see cref="IsEqualTo" />
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
        ///     Tests <see cref="IsGreaterThan" />
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
        ///     Tests <see cref="IsGreaterThanOrEqual" />
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
    }
}