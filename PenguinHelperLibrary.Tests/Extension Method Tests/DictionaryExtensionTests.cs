using System.Collections.Generic;
using AllOverIt.Fixture;
using PenguinHelperLibrary.Extension_Methods;
using Xunit;

namespace PenguinHelperLibrary.Tests.Extension_Method_Tests
{
    public class DictionaryExtensionTests
    {
        public class GetValueOrDefault : AoiFixtureBase
        {
            [Fact]
            public void GetValueOrDefaultTest()
            {
                var dict = new Dictionary<int, int>
                {
                    [1] = 11,
                    [2] = 22
                };

                var result = dict.GetValueOrDefault(3);
            }
        }

        public class AddKeyValuePair : AoiFixtureBase
        {
        }
    }
}