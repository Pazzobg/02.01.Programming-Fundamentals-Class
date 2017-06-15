namespace _10.SrybskoUnleashed
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class SrybskoUnleashed
    {
        public static void Main()
        {
            var venues = new Dictionary<string, Dictionary<string, int>>();

            string line = Console.ReadLine();

            while (line != "End")
            {

                string[] input = line.Split(' ');

                // Check if input consists of 4 parts
                if (input.Length < 4)
                {
                    line = Console.ReadLine();
                    continue;
                }

                // Check if there's an input part, starting with @. Loop doesn't start from 0, as if input[0] 
                bool atFound = false;   // starts with an @, then it's obviously wrong
                int venueStart = 0;
                for (int i = 1; i < input.Length; i++)
                {
                    if (input[i].StartsWith("@"))
                    {
                        atFound = true;
                        venueStart = i;
                        break;
                    }
                }
                if (!atFound)
                {
                    line = Console.ReadLine();
                    continue;
                }

                // Build artist name
                string artist = string.Empty;
                for (int i = 0; i < venueStart; i++)
                {
                    artist += input[i];
                    artist += " ";
                }
                artist = artist.TrimEnd();

                // Check if artist's name is of up to 3 words
                if ((artist.Split(' ')).Length > 3)
                {
                    line = Console.ReadLine();
                    continue;
                }

                // Build venue name
                string venueName = string.Empty;
                for (int i = venueStart; i < input.Length - 2; i++)
                {
                    venueName += input[i];
                    venueName += " ";
                }
                venueName = venueName.TrimEnd();

                // Check if venue's name is of up to 3 words
                if ((venueName.Split(' ')).Length > 3)
                {
                    line = Console.ReadLine();
                    continue;
                }

                // Check if there's another @
                bool anotherAt = false;
                for (int i = 1; i < venueName.Length; i++)
                {
                    if (venueName[i].Equals(new char[] { '@', '1', '2', '3', '4', '5', '6', '7', '8', '9', '0' }))
                    {
                        anotherAt = true;
                        break;
                    }
                }
                if (anotherAt)
                {
                    line = Console.ReadLine();
                    continue;
                }

                venueName = venueName.TrimStart('@');

                int ticketPrice = 0;
                bool priceExists = int.TryParse(input[input.Length - 2], out ticketPrice);
                int ticketCount = 0;
                bool countExists = int.TryParse(input[input.Length - 1], out ticketCount);
                if (!priceExists || !countExists)
                {
                    line = Console.ReadLine();
                    continue;
                }

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