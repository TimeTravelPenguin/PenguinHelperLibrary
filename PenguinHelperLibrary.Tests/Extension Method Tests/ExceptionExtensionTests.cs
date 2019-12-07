#region Title Header

// Name: Phillip Smith
// 
// Solution: PenguinHelperLibrary
// Project: PenguinHelperLibrary.Tests
// File Name: ExceptionExtensionTests.cs
// 
// Current Data:
// 2019-12-07 3:30 PM
// 
// Creation Date:
// 2019-12-07 3:06 PM

#endregion

using System;
using AllOverIt.Fixture;
using FluentAssertions;
using PenguinHelperLibrary.Extension_Methods;
using Xunit;

namespace PenguinHelperLibrary.Tests.Extension_Method_Tests
{
    public class ExceptionExtensionTests
    {
        public class TryOrThrowTests : AoiFixtureBase
        {
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