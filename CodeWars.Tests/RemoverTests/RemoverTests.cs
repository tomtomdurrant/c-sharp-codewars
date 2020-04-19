using System.Collections.Generic;
using Xunit;

namespace CodeWars.Tests.RemoverTests
{
    public class RemoverTests
    {
        public static void Tester(List<int> argument, List<int> expectedResult)
        {
            Assert.Equal(expectedResult, Remover.Remover.RemoveSmallest(argument));
        }
        
        [Fact]
        public void BasicTests()
        {
            Tester(new List<int>{1, 2, 3, 4, 5},new List<int>{2, 3, 4, 5});
            Tester(new List<int>{5, 3, 2, 1, 4},new List<int>{5, 3, 2, 4});
            Tester(new List<int> {1, 2, 3, 1, 1}, new List<int> {2, 3, 1, 1});
        }
        
    }
}