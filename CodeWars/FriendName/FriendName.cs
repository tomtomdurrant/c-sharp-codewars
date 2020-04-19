using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace CodeWars.FriendName
{
    public class FriendName
    {
        public static IEnumerable<string> FriendOrFoe(string[] names)
        {
            return names.Where(n => n.Length == 4);
        }
    }
}