using System;

namespace CodeWars.Factorial
{
    public class Factorial
    {
        public static int Method(int n)
        {
            if (n > 12 || n < 0)
            {
                throw new ArgumentOutOfRangeException();
            }
            var runningTotal = 1;
            for (int i = 1; i <= n; i++)
            {
                runningTotal *= i;
            }

            return runningTotal;
        }
    }
}