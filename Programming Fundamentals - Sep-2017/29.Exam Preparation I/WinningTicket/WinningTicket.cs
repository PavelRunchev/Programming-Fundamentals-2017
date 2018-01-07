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
            var inputTickets = Console.ReadLine()
                .Split(new char[] { ',', ' ' },
                StringSplitOptions.RemoveEmptyEntries);
            for (int i = 0; i < inputTickets.Length; i++)
            {
                string ticket = inputTickets[i];
                string jackpot = @"(?<left>@{10}|#{10}|\^{10}|\${10})(?<right>\1)";
                string leftPattern = @"\w*(?<left>@{6,9}|#{6,9}|\^{6,9}|\${6,9})";

                if(ticket.Length == 20)
                {
                    Match regex = Regex.Match(ticket, jackpot);
                    string left = ticket.Substring(0, 10);
                    string right = ticket.Substring(10);
                    Match regex1 = Regex.Match(left, leftPattern);
                    Match regex2 = Regex.Match(right, leftPattern);
                 
                    if (regex.Success)
                    {
                        int leftWinning = regex.Groups["left"].Length;
                        int rightWinning = regex.Groups["right"].Length;
                        if(leftWinning == rightWinning)
                        {
                            Console.WriteLine($"ticket \"{ticket}\" - {10}{regex.Groups["left"].Value.First()} Jackpot!");
                        }
                    }
                    else if (regex1.Success && regex2.Success)
                    {
                        if (left[5] == right[5])
                        {
                            int leftMatch = regex1.Groups["left"].Value.Count();
                            int rightMatch = regex2.Groups["left"].Value.Count();
                            int count = Math.Min(leftMatch, rightMatch);
                            Console.WriteLine($"ticket \"{ticket}\" - {count}{regex1.Groups["left"].Value.First()}");
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
