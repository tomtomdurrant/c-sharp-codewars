using System.Collections;
using System.Collections.Generic;
using Xunit;

namespace CodeWars.Tests.FriendNameTests
{
    public class FriendNameTests
    {
        [Fact]
        public void Test()
        {
            string[] expected = {"Ryan", "Mark"};
            string[] input = {"Ryan", "Kieran", "Mark", "Jimmy"};
            var result = FriendName.FriendName.FriendOrFoe(input);
            Assert.Equal(expected, result);
        }
    }
}