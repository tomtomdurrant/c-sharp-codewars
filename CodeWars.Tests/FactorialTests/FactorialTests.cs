using Xunit;

namespace CodeWars.Tests.FactorialTests
{
    public class FactorialTests
    {
        [Theory]
        [InlineData(0, 1)]
        [InlineData(2, 2)]
        [InlineData(3, 6)]
        public void BasicTests(int input, int expectedResult)
        {
            Assert.Equal(expectedResult, Factorial.Factorial.Method(input));
        }
    }
}