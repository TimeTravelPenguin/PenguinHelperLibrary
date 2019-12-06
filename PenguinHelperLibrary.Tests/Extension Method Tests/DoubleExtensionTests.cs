using System;
using AllOverIt.Fixture;
using FluentAssertions;
using PenguinHelperLibrary.Extension_Methods;
using Xunit;
using Xunit.Sdk;

namespace PenguinHelperLibrary.Tests.Extension_Method_Tests
{
    public class DoubleExtensionTests
    {
        public class IsZeroTests
        {
            [Theory]
            [InlineData(-1)]
            [InlineData(-5.5)]
            [InlineData(-3)]
            [InlineData(3.5)]
            [InlineData(double.Epsilon)]
            [InlineData(double.MinValue)]
            [InlineData(double.MaxValue)]
            [InlineData(double.PositiveInfinity)]
            [InlineData(double.NegativeInfinity)]
            public void IsZeroTest_False(double expected)
            {
                expected.IsZero().Should().BeFalse();
            }

            [Fact]
            public void IsZeroTest_True()
            {
                const double zero = 0;
                zero.IsZero().Should().BeTrue();
            }
        }

        public class IsEqualToTests : AoiFixtureBase
        {
            [Fact]
            public void IsEqualTo_True_double()
            {
                var actual = Create<double>();
                actual.IsEqualTo(actual).Should().BeTrue();
            }

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
            public void IsEqualTo_False_Infinity(double expected)
            {
                expected.IsEqualTo(expected).Should().BeFalse();
            }

            [Fact]
            public void IsEqualTo_False()
            {
                var lhs = Create<double>();

                double notZero;
                do
                {
                    notZero = Create<double>();
                } while (Math.Abs(notZero) <= double.Epsilon);

                var rhs = lhs + notZero;

                lhs.IsEqualTo(rhs).Should().BeFalse();
            }
        }
    }
}