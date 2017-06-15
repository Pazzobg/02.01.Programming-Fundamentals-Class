namespace _11.DragonArmy
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class DragonArmy
    {
        public static void Main()
        {
            var dragons = new Dictionary<string, SortedDictionary<string, Dictionary<string, int>>>();

            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                string[] input = Console.ReadLine().Split(' ');

                string currentType = input[0];
                string currentName = input[1];

                int damage = 0;
                bool hasDamageStats = int.TryParse(input[2], out damage);
                if (!hasDamageStats) damage = 45;

                int health = 0;
                bool hasHealthStats = int.TryParse(input[3], out health);
                if (!hasHealthStats) health = 250;

                int armor = 0;
                bool hasArmorStats = int.TryParse(input[4], out armor);
                if (!hasArmorStats) armor = 10;

                if (!dragons.ContainsKey(currentType))
                {
                    dragons[currentType] = new SortedDictionary<string, Dictionary<string, int>>();
                }

                if (!dragons[currentType].ContainsKey(currentName))
                {
                    dragons[currentType][currentName] = new Dictionary<string, int>();
                }

                dragons[currentType][currentName]["damage"] = damage;
                dragons[currentType][currentName]["health"] = health;
                dragons[currentType][currentName]["armor"] = armor;
            }

            foreach (var outerKvp in dragons)
            {
                string type = outerKvp.Key;
                var dragonsSameType = outerKvp.Value;

                double avgDamage = dragonsSameType.Select(x => x.Value["damage"]).Average();
                double avgHealth = dragonsSameType.Select(x => x.Value["health"]).Average();
                double avgArmor = dragonsSameType.Select(x => x.Value["armor"]).Average();

                Console.WriteLine($"{type}::({avgDamage:f2}/{avgHealth:f2}/{avgArmor:f2})");

                foreach (var middleKvp in dragonsSameType)
                {
                    string name = middleKvp.Key;
                    var dragonStats = middleKvp.Value;

                    Console.WriteLine($"-{name} -> " +
                        $"damage: {dragonStats["damage"]}, " +
                        $"health: {dragonStats["health"]}, " +
                        $"armor: {dragonStats["armor"]}");
                }
            }
        }
    }
}
