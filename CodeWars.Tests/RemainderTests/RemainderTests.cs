using Xunit;

namespace CodeWars.Tests.RemainderTests
{
    public class RemainderTests
    {
        [Theory]
        [InlineData(1, 5)]
        [InlineData(3, 5)]
        [InlineData(11, 15)]
        [InlineData(5, 5)]
        [InlineData(0, 0)]
        public void Test(int input, int expected)
        {
            Assert.Equal(expected, Remainder.Remainder.RoundToNext5(input));
        }
    }
}