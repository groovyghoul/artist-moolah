using FluentAssertions;
using Xunit;

namespace ArtistMoolah.Tests
{
    public class HelloTests
    {
        [Fact]
        public void Test()
        {
            var actual = "ABCDEFGHI";
            actual.Should().StartWith("AB").And.EndWith("HI").And.Contain("EF").And.HaveLength(9);
        }
    }
}