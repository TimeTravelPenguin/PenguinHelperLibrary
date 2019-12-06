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
        public class IsZeroTests : AoiFixtureBase
        {
            [Theory]
            [InlineData(double.Epsilon)]
            [InlineData(double.MinValue)]
            [InlineData(double.MaxValue)]
            [InlineData(double.PositiveInfinity)]
            [InlineData(double.NegativeInfinity)]
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

        public class IsEqualToTests : AoiFixtureBase
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
            public void IsEqualTo_False_Infinity(double expected)
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
            public void IsEqualTo_True_double()
            {
                var actual = Create<double>();
                actual.IsEqualTo(actual).Should().BeTrue();
            }
        }

        public class IsGreaterThan
        {
        }
    }
}