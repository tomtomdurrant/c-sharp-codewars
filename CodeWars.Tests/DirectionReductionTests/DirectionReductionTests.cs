using System;
using Xunit;

namespace CodeWars.Tests
{
    public class DirectionReductionTests
    {
        [Fact]
        public void WhenGivenNorthTheDirectionIsNorth()
        {
            var justNorthInput = new[] {"North"};
            var justNorthOutput = new[] {"North"};

            var result = DirectionReduction.Reduce(justNorthInput);
            Assert.Equal(justNorthOutput, result);
        }
        
        [Fact]
        public void WhenGivenTwoInputsThatDoNotCancelResultIsTheSame()
        {
            var input = new[] {"North", "West"};
            var expected = new[] {"North", "West"};

            var result = DirectionReduction.Reduce(input);
            Assert.Equal(expected, result);
        }
        
        [Fact]
        public void WhenGivenNorthSouthAnEmptyIsReturned()
        {
            var input = new[] {"North", "South"};
            var expected = new string[]{};

            var result = DirectionReduction.Reduce(input);
            Assert.Equal(expected, result);
        }
        
        [Fact]
        public void WhenGivenSouthNorthAnEmptyIsReturned()
        {
            var input = new[] {"South", "North"};
            var expected = new string[]{};

            var result = DirectionReduction.Reduce(input);
            Assert.Equal(expected, result);
        }
        
        [Fact]
        public void WhenGivenEastWestAnEmptyIsReturned()
        {
            var input = new[] {"East", "West"};
            var expected = new string[]{};

            var result = DirectionReduction.Reduce(input);
            Assert.Equal(expected, result);
        }
        
        [Fact]
        public void WhenGivenNorthSouthEastWestAnEmptyIsReturned()
        {
            var input = new[] {"North", "South", "East", "West"};
            var expected = new string[]{};

            var result = DirectionReduction.Reduce(input);
            Assert.Equal(expected, result);
        }
        
        [Fact]
        public void WhenGivenNorthEastSouthWestInputIsReturned()
        {
            var input = new[] {"North", "East", "South", "West"};
            var expected = new [] {"North", "East", "South", "West"}; 

            var result = DirectionReduction.Reduce(input);
            Assert.Equal(expected, result);
        }
        
        [Fact]
        public void WhenGivenAnArrayOfAllCapsItIsExecutedProperly()
        {
            var input = new[] {"NORTH", "SOUTH"};
            var expected = new string[] { };

            var result = DirectionReduction.Reduce(input);
            Assert.Equal(expected, result);
        }
        
        [Fact]
        public void WhenGivenAComplexArrayOneItemIsReturned()
        {
            var input = new[] {"NORTH", "SOUTH", "SOUTH", "EAST", "WEST", "NORTH", "WEST"};
            var expected = new[] {"WEST"};

            var result = DirectionReduction.Reduce(input);
            Assert.Equal(expected, result);
        }
    }
}