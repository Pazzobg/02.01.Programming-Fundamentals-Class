namespace _03.RegexMon
{
    using System;
    using System.Text.RegularExpressions;

    public class RegexMon
    {
        public static void Main()
        {
            string patternDidi = @"[^a-zA-Z\-]+";
            string patternBojo = @"[a-zA-Z]+-[a-zA-Z]+";

            var regexDidi = new Regex(patternDidi);
            var regecBojo = new Regex(patternBojo);

            string inputLine = Console.ReadLine();
            bool currentPlayerFoundMatch = true;
            int counter = 1;

            while (currentPlayerFoundMatch)
            {
                if (counter % 2 != 0)       // Didi's turn
                {
                    var match = regexDidi.Match(inputLine);

                    if (!match.Success)
                    {
                        currentPlayerFoundMatch = false;
                        continue;
                    }

                    string currentMatchFound = match.Groups[0].Value;
                    Console.WriteLine(currentMatchFound);

                    if (match.Index > 0)
                    {
                        inputLine = inputLine.Remove(0, match.Index);
                    }

                    inputLine = inputLine.Remove(0, currentMatchFound.Length);
                }
                else                          // Bojo's turn
                {
                    var match = regecBojo.Match(inputLine);

                    if (!match.Success)
                    {
                        currentPlayerFoundMatch = false;
                        continue;
                    }

                    string currentMatchFound = match.Groups[0].Value;
                    Console.WriteLine(currentMatchFound);

                    if (match.Index > 0)
                    {
                        inputLine = inputLine.Remove(0, match.Index);
                    }

                    inputLine = inputLine.Remove(0, currentMatchFound.Length);
                }

                counter++;
            }
        }
    }
}
