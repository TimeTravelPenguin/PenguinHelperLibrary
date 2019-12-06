using AllOverIt.Fixture;
using FluentAssertions;
using PenguinHelperLibrary.Extension_Methods;
using Xunit;

namespace PenguinHelperLibrary.Tests.Extension_Method_Tests
{
    public class EnumExtensionTests
    {
        private enum Numbers
        {
            Zero,
            One,
            Two,
            Three,
            Four,
            Five,
            Six,
            Seven,
            Eight,
            Nine,
            Ten
        }

        public class EnumToArray : AoiFixtureBase
        {
            [Fact]
            public void EnumToArrayTest()
            {
                var counter = 0;
                foreach (var number in EnumExtensions.EnumToArray<Numbers>())
                {
                    number.Should().Be((Numbers) counter++);
                }
            }
        }
    }
}