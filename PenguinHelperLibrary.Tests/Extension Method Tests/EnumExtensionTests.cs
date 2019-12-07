#region Title Header

// Name: Phillip Smith
// 
// Solution: PenguinHelperLibrary
// Project: PenguinHelperLibrary.Tests
// File Name: EnumExtensionTests.cs
// 
// Current Data:
// 2019-12-07 1:10 AM
// 
// Creation Date:
// 2019-12-06 6:22 PM

#endregion

using AllOverIt.Fixture;
using FluentAssertions;
using JetBrains.Annotations;
using PenguinHelperLibrary.Extension_Methods;
using Xunit;

namespace PenguinHelperLibrary.Tests.Extension_Method_Tests
{
    [UsedImplicitly]
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
                var index = 0;
                foreach (var number in EnumExtensions.EnumToArray<Numbers>())
                {
                    number.Should().Be((Numbers) index++);
                }
            }
        }
    }
}