using Xunit;

namespace CodeWars.Tests
{
    public class NewDirectionReductionTests
    {
        [Fact]
        public void WhenGivenNorthTheDirectionIsNorth()
        {
            var justNorthInput = new[] {"North"};
            var justNorthOutput = new[] {"North"};

            var result = NewDirectionReduction.Reduce(justNorthInput);
            Assert.Equal(justNorthOutput, result);
        }
        
        [Fact]
        public void WhenGivenNorthSouthAnEmptyIsReturned()
        {
            var input = new[] {"North", "South"};
            var expected = new string[] { };

            var result = NewDirectionReduction.Reduce(input);
            Assert.Equal(expected, result);
        }
        
        [Fact]
        public void WhenGivenNorthNorthItIsReturned()
        {
            var input = new[] {"North", "North"};
            var expected = new[] {"North", "North"};

            var result = NewDirectionReduction.Reduce(input);
            Assert.Equal(expected, result);
        }
        
        [Fact]
        public void WhenGivenNorthSouthNorthNorthNorth_NorthNorthNorthIsReturned()
        {
            var input = new[] {"North", "South", "North", "North", "North"};
            var expected = new[] {"North", "North", "North"};

            var result = NewDirectionReduction.Reduce(input);
            Assert.Equal(expected, result);
        }
    }
}