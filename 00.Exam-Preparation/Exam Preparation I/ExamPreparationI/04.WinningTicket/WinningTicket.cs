namespace _04.WinningTicket_2
{
    using System;
    using System.Linq;
    using System.Text.RegularExpressions;

    public class WinningTicket
    {
        public static void Main()
        {
            string winningPattern = @"((@{6,10})|#{6,10}|\${6,10}|\^{6,10})";

            string[] tickets = Console.ReadLine().Split(',').Select(t => t.Trim()).ToArray();

            foreach (var ticket in tickets)
            {
                if (ticket.Length != 20)
                {
                    Console.WriteLine("invalid ticket");
                }
                else
                {
                    var match = Regex.Match(ticket, winningPattern);

                    string leftPart = ticket.Substring(0, 10);
                    string rightPart = ticket.Substring(10, 10);

                    var matchLeft = Regex.Match(leftPart, winningPattern);
                    var matchRight = Regex.Match(rightPart, winningPattern);

                    if (matchLeft.Success && matchRight.Success && leftPart[5] == rightPart[5])
                    {                                               // if there's a winning substring, the char at 
                        char winningSymbol = leftPart[5];           // pos 5 or 6 is part of the substr. always.

                        int matchSymbolsCount = Math.Min(matchLeft.Value.Count(), matchRight.Value.Count());

                        Console.Write($"ticket \"{ticket}\" - {matchSymbolsCount}{winningSymbol}");
                        Console.WriteLine(matchSymbolsCount == 10 ? " Jackpot!" : string.Empty);
                    }
                    else
                    {
                        Console.WriteLine($"ticket \"{ticket}\" - no match");
                    }
                }
            }
        }
    }
}
