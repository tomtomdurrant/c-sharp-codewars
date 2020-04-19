namespace CodeWars.Remainder
{
    public class Remainder
    {
        public static int RoundToNext5(int n)
        {
            if (n % 5 == 0)
            {
                return n;
            }
            return 5 - (n % 5) + n;
        }
    }
}