namespace _04.WinningTicket_2
{
    using System;
    using System.Linq;
    using System.Text.RegularExpressions;
                                            // My solution - result 80/100
    public class WinningTicket
    {
        public static void Main()
        {
            string validityPattern = @"^.{20}$";
            string winningPattern = @"^.*?((\$|@|\^|#){6,10}).*?(\1).*?$";
            var validityregex = new Regex(validityPattern);

            string[] tickets = Console.ReadLine().Split(',').Select(t => t.Trim()).ToArray();

            foreach (var ticket in tickets)
            {
                var validation = validityregex.Match(ticket);

                if (!validation.Success)
                {
                    Console.WriteLine("invalid ticket");
                }
                else
                {
                    var match = Regex.Match(ticket, winningPattern);

                    if (!match.Success)
                    {
                        Console.WriteLine($"ticket \"{ticket}\" - no match");
                    }
                    else
                    {
                        char winningSymbol = match.Groups[1].Value.ToString()[0];

                        switch (match.Groups[1].Length)
                        {
                            case 10: Console.WriteLine($"ticket \"{ticket}\" - 10{winningSymbol} Jackpot!"); break;
                            default:
                                Console.WriteLine($"ticket \"{ticket}\" - {match.Groups[1].Length}{winningSymbol}"); break;
                        }
                    }
                }
            }
        }
    }
}
