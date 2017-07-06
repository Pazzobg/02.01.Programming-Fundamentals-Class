namespace _04.PopulationAggregation
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Text.RegularExpressions;

    public class PopulationAggregation
    {
        public static void Main()
        {
            var countriesCitiesCounts = new SortedDictionary<string, List<string>>();
            var citiesPopulations = new Dictionary<string, long>();

            string line = Console.ReadLine();

            while (line != "stop")
            {
                string[] input = line.Split('\\');

                string countryToken = string.Empty;
                string cityToken = string.Empty;
                long population = long.Parse(input[2]);

                char firstChar = input[0][0];
                if (char.IsUpper(firstChar))
                {
                    countryToken = input[0];
                    cityToken = input[1];
                }
                else
                {
                    countryToken = input[1];
                    cityToken = input[0];
                }

                string country = RemoveProhibitedSymbolsFromName(countryToken);
                string city = RemoveProhibitedSymbolsFromName(cityToken);
                
                // add country-city pair to dict.
                if (!countriesCitiesCounts.ContainsKey(country))     
                {
                    countriesCitiesCounts[country] = new List<string>();
                }

                countriesCitiesCounts[country].Add(city);

                // add city-population pair to another dict.
                if (!citiesPopulations.ContainsKey(city))           
                {
                    citiesPopulations[city] = 0;
                }

                citiesPopulations[city] = population;

                line = Console.ReadLine();
            }

            foreach (var kvp in countriesCitiesCounts)
            {
                Console.WriteLine($"{kvp.Key} -> {kvp.Value.Count}");
            }

            foreach (var kvp in citiesPopulations.OrderByDescending(x => x.Value).Take(3))
            {
                Console.WriteLine($"{kvp.Key} -> {kvp.Value}");
            }
        }

        public static string RemoveProhibitedSymbolsFromName(string token)
        {
            string patternSplit = @"[0-9@#\$&]";

            string[] resultAsCharArr = Regex.Split(token, patternSplit);

            var sb = new StringBuilder();

            for (int i = 0; i < resultAsCharArr.Length; i++)
            {
                sb.Append(resultAsCharArr[i]);
            }

            return sb.ToString();
        }
    }
}
