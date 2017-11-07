using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;

namespace WinningTicket
{
    class WinningTicket
    {
        static void Main()
        {
            string jackpotPattern = @"(?<left>@{10}|#{10}|\${10}|\^{10})(?<right>\1)";
            string matchedPattern = @"(?<left>\@{6,9}|#{6,9}|\${6,9}|\^{6,9})";
            Regex regexJackpot = new Regex(jackpotPattern);
      
            var inputTickets = Console.ReadLine()
                .Split(new char[] { ' ', ',', },
                StringSplitOptions.RemoveEmptyEntries);
            for (int i = 0; i < inputTickets.Length; i++)
            {
                string ticket = inputTickets[i];
                if (ticket.Length == 20)
                {
                    Match JackpotMatched = regexJackpot.Match(ticket);

                    string left = ticket.Substring(0, 10);
                    string right = ticket.Substring(10);
                    Match leftPart = Regex.Match(left, matchedPattern);
                    Match rightPart = Regex.Match(right, matchedPattern);
                    if (JackpotMatched.Success)
                    {                   
                            Console.WriteLine($"ticket \"{ticket}\" - {10}{ticket[0]} Jackpot!");
                    }
                    else if(leftPart.Success && rightPart.Success)
                    {
                        if(left[5] == right[5])
                        {
                            int leftSize = leftPart.Groups["left"].Value.Count();
                            int rightSize = rightPart.Groups["left"].Value.Count();
                            int size = Math.Min(leftSize, rightSize);
                            Console.WriteLine($"ticket \"{ticket}\" - {size}{ticket[4]}");
                        }
                        else
                        {
                            Console.WriteLine($"ticket \"{ticket}\" - no match");
                        }                
                    }
                    else
                    {
                        Console.WriteLine($"ticket \"{ticket}\" - no match");
                    }
                }
                else
                {
                    Console.WriteLine("invalid ticket");
                }
            }
        }
    }
}
