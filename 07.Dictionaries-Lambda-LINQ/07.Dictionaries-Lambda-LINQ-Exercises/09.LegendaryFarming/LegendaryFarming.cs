namespace _09.LegendaryFarming
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class LegendaryFarming
    {
        public static void Main()
        {
            var resources = new SortedDictionary<string, int>
            {
                {"shards", 0 },
                {"fragments", 0 },
                {"motes", 0 }
            };

            var junk = new SortedDictionary<string, int>();

            bool legendaryFound = false;
            string resourcesEnough = string.Empty;

            while (!legendaryFound)
            {
                string[] input = Console.ReadLine().ToLower().Split(' ');

                for (int i = 1; i < input.Length; i+=2)
                {
                    string currentMaterial = input[i];
                    int currentQuantity = int.Parse(input[i - 1]);

                    if (resources.ContainsKey(currentMaterial))
                    {
                        resources[currentMaterial] += currentQuantity;

                        if (resources[currentMaterial] >= 250)
                        {
                            legendaryFound = true;
                            resources[currentMaterial] -= 250;
                            resourcesEnough = currentMaterial;
                            break;
                        }
                    }
                    else
                    {
                        if (!junk.ContainsKey(currentMaterial))
                        {
                            junk[currentMaterial] = 0;
                        }

                        junk[currentMaterial] += currentQuantity;
                    }
                }
            }

            switch (resourcesEnough)
            {
                case "shards": Console.WriteLine("Shadowmourne obtained!"); break;
                case "fragments": Console.WriteLine("Valanyr obtained!"); break;
                case "motes": Console.WriteLine("Dragonwrath obtained!"); break;
            }

            foreach (var kvp in resources.OrderByDescending(x => x.Value))
            {
                Console.WriteLine($"{kvp.Key}: {kvp.Value}");
            }
            foreach (var item in junk)
            {
                Console.WriteLine($"{item.Key}: {item.Value}");
            }
        }
    }
}