using System.Collections.Generic;
using System.Linq;

namespace CodeWars.Remover
{
    public class Remover
    {
        public static List<int> RemoveSmallest(List<int> numbers)
        {
            var sorted = numbers.OrderBy(x => x).ToList();
            sorted.RemoveAt(0);
            return sorted;

        }
    }
}