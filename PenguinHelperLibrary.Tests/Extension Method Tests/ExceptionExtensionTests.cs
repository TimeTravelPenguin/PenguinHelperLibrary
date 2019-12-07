#region Title Header

// Name: Phillip Smith
// 
// Solution: PenguinHelperLibrary
// Project: PenguinHelperLibrary.Tests
// File Name: ExceptionExtensionTests.cs
// 
// Current Data:
// 2019-12-07 2:51 PM
// 
// Creation Date:
// 2019-12-07 2:29 PM

#endregion

using System;
using AllOverIt.Fixture;
using PenguinHelperLibrary.Extension_Methods;
using Xunit;

namespace PenguinHelperLibrary.Tests.Extension_Method_Tests
{
    public class ExceptionExtensionTests : AoiFixtureBase
    {
        public class TryOrThrowTests
        {
            [Fact]
            public void TryOrThrowTest()
            {
                bool AreEqual(int a, int b) => a == b;

                Action act = () => AreEqual(1, 1);


                act.TryOrThrow(new Exception("This is a test"));
            }
        }
    }
}