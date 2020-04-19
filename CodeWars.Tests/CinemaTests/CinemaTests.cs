using Xunit;

namespace CodeWars.Tests.CinemaTests
{
    public class CinemaTests
    {
        [Fact]
        public void WhenGiven25TheAnswerIsYes()
        {
            var input = new[] {25};
            var expected = "YES";

            var result = Cinema.Cinema.Tickets(input);
            Assert.Equal(expected, result);
        }

        [Fact]
        public void WhenGivenMoreThanOne25TheAnswerIsYes()
        {
            var input = new[] {25, 25};
            var expected = "YES";

            var result = Cinema.Cinema.Tickets(input);
            Assert.Equal(expected, result);
        }

        [Fact]
        public void WhenGivenA100TheAnswerIsNo()
        {
            var input = new[] {100};
            var expected = "NO";

            var result = Cinema.Cinema.Tickets(input);
            Assert.Equal(expected, result);
        }
        
        [Fact]
        public void WhenGivenEnoughChange()
        {
            var input = new[] {25, 50};
            var expected = "YES";

            var result = Cinema.Cinema.Tickets(input);
            Assert.Equal(expected, result);
        }

        [Fact]
        public void LargerLine()
        {
            var input = new int[] {25, 25, 50, 50, 100};
            var expected = "NO";

            var result = Cinema.Cinema.Tickets(input);
            Assert.Equal(expected, result);
        }
    }
}