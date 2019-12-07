#region Title Header

// Name: Phillip Smith
// 
// Solution: PenguinHelperLibrary
// Project: PenguinHelperLibrary.Tests
// File Name: EnumExtensionTests.cs
// 
// Current Data:
// 2019-12-07 3:48 PM
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
    ///     Tests <see cref="EnumExtensions" />
    /// </summary>
    [UsedImplicitly]
    public class EnumExtensionTests
    {
        // Used exclusively for testing enums
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

        /// <summary>
        ///     Tests <see cref="EnumExtensions.EnumToArray{T}" />
        /// </summary>
        public class EnumToArrayTests : AoiFixtureBase
        {
            /// <summary>
            ///     Tests that an array is returned with all the appropriate enum values an have the correct type
            /// </summary>
            [Fact]
            public void EnumToArrayTest()
            {
                var index = 0;
                foreach (var number in EnumExtensions.EnumToArray<Numbers>())
                {
                    number
                        .Should()
                        .Be((Numbers) index++)
                        .And
                        .BeOfType<Numbers>();
                }
            }
        }
    }
}