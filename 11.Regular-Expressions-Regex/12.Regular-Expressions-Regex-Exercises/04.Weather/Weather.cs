namespace _04.Weather
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text.RegularExpressions;

    public class Weather
    {
        public static void Main()
        {
            var cities = new Dictionary<string, City>();

            string pattern = @"([A-Z]{2})(\d+\.\d+)([A-Za-z]+)\|";
            var regex = new Regex(pattern);

            string input = Console.ReadLine();

            while (input != "end")
            {
                if (regex.IsMatch(input))
                {
                    Match currentMatch = regex.Match(input);

                    string name = currentMatch.Groups[1].ToString();
                    double temperature = double.Parse(currentMatch.Groups[2].ToString());
                    string weather = currentMatch.Groups[3].ToString();

                    if (!cities.ContainsKey(name))
                    {
                        cities[name] = new City();
                    }

                    var currentCity = cities[name];

                    currentCity.Name = name;
                    currentCity.AverageTemp = temperature;
                    currentCity.Weather = weather;
                }

                input = Console.ReadLine();
            }

            foreach (var city in cities.OrderBy(x => x.Value.AverageTemp))
            {
                string cityName = city.Key;
                double averageTemp = city.Value.AverageTemp;
                string weather = city.Value.Weather;

                Console.WriteLine($"{cityName} => {averageTemp:f2} => {weather}");
            }
        }
    }
}
