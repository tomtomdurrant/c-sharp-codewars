using System;
using System.Collections.Generic;

namespace CodeWars
{
    public static class DirectionReduction
    {
        public static string[] Reduce(string[] input)
        {
            var list = new List<string>();
            list.AddRange(input);

            for (var i = 0; i < list.Count - 1; i++)
            {
                if ((list[i] == Dir.E && list[i + 1] == Dir.W)
                    || (list[i] == Dir.W && list[i + 1] == Dir.E)
                    || (list[i] == Dir.N && list[i + 1] == Dir.S)
                    || (list[i] == Dir.S && list[i + 1] == Dir.N))
                {
                    list.RemoveRange(i, 2);
                    i = -1;
                }
            }

            return list.ToArray();
        }
    }

    public static class Dir
    {
        public static string N = "NORTH",
            E = "EAST",
            S = "SOUTH",
            W = "WEST";
    }
}