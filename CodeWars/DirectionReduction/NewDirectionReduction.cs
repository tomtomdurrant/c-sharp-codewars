using System.Collections.Generic;
using System.Linq;

namespace CodeWars
{
    public static class NewDirectionReduction
    {
        public static string[] Reduce(string[] input)
        {
            var output = new List<string>(input);

            for (var i = 0; i < input.Length - 1; i++)
            {
               
                if ((input[i].ToUpper() == "NORTH" && input[i + 1].ToUpper() == "SOUTH") ||
                    (input[i].ToUpper() == "SOUTH" && input[i + 1].ToUpper() == "NORTH") ||
                    (input[i].ToUpper() == "WEST" && input[i + 1].ToUpper() == "EAST") || 
                    (input[i].ToUpper() == "EAST" && input[i + 1].ToUpper() == "WEST"))
                {
                    output.RemoveRange(i, 2);
                    i = -1;
                }
            }

            
            return output.ToArray();
        }
    }
}