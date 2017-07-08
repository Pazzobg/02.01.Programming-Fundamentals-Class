namespace _04.NSA
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text.RegularExpressions;

    public class NSA
    {
        public static void Main()
        {
            var countries = new Dictionary<string, Dictionary<string, int>>();
            var pattern = @"^[a-zA-Z0-9]+$";
            var regex = new Regex(pattern);

            string[] input = Console.ReadLine().Split(" ->".ToCharArray(), StringSplitOptions.RemoveEmptyEntries);

            while (input[0] != "quit")
            {
                string countryName = input[0];
                string spyName = input[1];
                int daysService = int.Parse(input[2]);

                var countryMatch = regex.Match(countryName);
                var spyMatch = regex.Match(spyName);

                if (!countryMatch.Success || !spyMatch.Success)
                {
                    input = Console.ReadLine().Split(" ->".ToCharArray(), StringSplitOptions.RemoveEmptyEntries);
                    continue;
                }

                if (!countries.ContainsKey(countryName))
                {
                    countries[countryName] = new Dictionary<string, int>();
                }

                if (!countries[countryName].ContainsKey(spyName))
                {
                    countries[countryName][spyName] = 0;
                }

                countries[countryName][spyName] = daysService;

                input = Console.ReadLine().Split(" ->".ToCharArray(), StringSplitOptions.RemoveEmptyEntries);
            }

            foreach (var kvp in countries.OrderByDescending(x => x.Value.Count))
            {
                string countryName = kvp.Key;
                var spyInfo = kvp.Value;

                Console.WriteLine($"Country: {countryName}");

                foreach (var spy in spyInfo.OrderByDescending(x => x.Value))
                {
                    string spyName = spy.Key;
                    int daysOfService = spy.Value;

                    Console.WriteLine($"**{spyName} : {daysOfService}");
                }
            }
        }
    }
}
