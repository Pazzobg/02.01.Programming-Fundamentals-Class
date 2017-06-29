namespace _10.SrybskoUnleashed_Regex_Az
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text.RegularExpressions;

    public class SrybskoUnleashedRegex
    {
        public static void Main()
        {
            var venues = new Dictionary<string, Dictionary<string, int>>();

            string pattern = @"(?<name>([a-zA-Z]+\s?){1,3}) @(?<venue>([A-Za-z]+\s?){1,3}) (?<price>\d+) (?<count>\d+)";
            var regex = new Regex(pattern);

            string line = Console.ReadLine();

            while (line != "End")
            {
                if (!regex.IsMatch(line))
                {
                    line = Console.ReadLine();
                    continue;
                }
                else
                {
                    Match match = regex.Match(line);

                    string artist = match.Groups["name"].Value;
                    string venueName = match.Groups["venue"].Value;
                    int ticketPrice = int.Parse(match.Groups["price"].Value);
                    int ticketCount = int.Parse(match.Groups["count"].Value);

                    if (!venues.ContainsKey(venueName))
                    {
                        venues[venueName] = new Dictionary<string, int>();
                    }

                    if (!venues[venueName].ContainsKey(artist))
                    {
                        venues[venueName][artist] = 0;
                    }

                    venues[venueName][artist] += ticketPrice * ticketCount;

                    line = Console.ReadLine();
                }
            }

            foreach (var outerKvp in venues)
            {
                Console.WriteLine(outerKvp.Key);

                var artistsAtVenue = outerKvp.Value;

                foreach (var innerKvp in artistsAtVenue.OrderByDescending(x => x.Value))
                {
                    Console.WriteLine($"#  {innerKvp.Key} -> {innerKvp.Value}");
                }
            }
        }
    }
}
