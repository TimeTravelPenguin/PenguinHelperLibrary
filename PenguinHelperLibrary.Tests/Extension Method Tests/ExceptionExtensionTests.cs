#region Title Header

// Name: Phillip Smith
// 
// Solution: PenguinHelperLibrary
// Project: PenguinHelperLibrary.Tests
// File Name: ExceptionExtensionTests.cs
// 
// Current Data:
// 2019-12-07 3:51 PM
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
    ///     Tests <see cref="Extension_Methods.ExceptionExtensions" />
    /// </summary>
    [UsedImplicitly]
    public class ExceptionExtensionTests
    {
        /// <summary>
        ///     Tests <see cref="Extension_Methods.ExceptionExtensions.TryOrThrow(Action, Exception)" />
        /// </summary>
        public class TryOrThrowTests : AoiFixtureBase
        {
            /// <summary>
            ///     Tests that the method throws when appropriate
            /// </summary>
            [Fact]
            public void TryOrThrowTest()
            {
                bool AreEqual(int a, int b)
                {
                    return a == b ? true : throw new Exception();
                }

                Action act = () => AreEqual(1, 2);

                Invoking(() => act.TryOrThrow(new Exception("This is a test")))
                    .Should()
                    .Throw<Exception>()
                    .WithMessage("This is a test");
            }
        }
    }
}