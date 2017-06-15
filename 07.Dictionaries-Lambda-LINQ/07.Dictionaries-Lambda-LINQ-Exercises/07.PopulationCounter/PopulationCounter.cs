namespace _07.PopulationCounter
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class PopulationCounter
    {
        public static void Main()
        {
            var countriesDict = new Dictionary<string, Dictionary<string, long>>();

            string[] input = Console.ReadLine().Split('|');

            while (input[0] != "report")
            {
                string country = input[1];
                string city = input[0];
                long population = long.Parse(input[2]);

                if (!countriesDict.ContainsKey(country))
                {
                    countriesDict[country] = new Dictionary<string, long>();
                }

                if (!countriesDict[country].ContainsKey(city))
                {
                    countriesDict[country][city] = 0;
                }

                countriesDict[country][city] = population;

                input = Console.ReadLine().Split('|');
            }

            foreach (var kvp in countriesDict.OrderByDescending(cntry => cntry.Value.Sum(cty => cty.Value)))
            {
                string country = kvp.Key;
                var citiesDict = kvp.Value;

                long totalCountryPopulation = 0;
                foreach (var kvp2 in citiesDict)
                {
                    totalCountryPopulation += kvp2.Value;
                }

                Console.WriteLine($"{country} (total population: {totalCountryPopulation})");

                foreach (var city in citiesDict.OrderByDescending(x => x.Value))
                {
                    Console.WriteLine($"=>{city.Key}: {city.Value}");
                }
            }
        }
    }
}