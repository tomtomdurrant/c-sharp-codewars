using System.Reflection;

namespace CodeWars.Cinema
{
    public class Cinema
    {
        public static string Tickets(int[] peopleInLine)
        {
            var answer = "NO";
            const int ticketPrice = 25;
            var amountOfChange = 0;
            foreach (var customer in peopleInLine)
            {
                if (customer == ticketPrice)
                {
                    amountOfChange += ticketPrice;
                    answer = "YES";
                }
                else
                {
                    var localAmount = amountOfChange - customer + ticketPrice;
                    if (localAmount >= 0)
                    {
                        amountOfChange = customer - ticketPrice;
                        answer = "YES";
                    }
                    else
                    {
                        answer = "NO";
                        
                    }


                }
                
            }
            return answer;
        }
        
    }
}