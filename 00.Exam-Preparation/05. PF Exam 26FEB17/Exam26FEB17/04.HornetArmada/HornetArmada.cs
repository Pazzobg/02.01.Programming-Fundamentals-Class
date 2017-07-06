namespace _04.HornetArmada
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class HornetArmada
    {
        public static void Main()
        {
            var legions = new Dictionary<string, Legion>();

            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                string[] input = Console.ReadLine().Split(" =->:".ToCharArray(), StringSplitOptions.RemoveEmptyEntries);
                int lastActivity = int.Parse(input[0]);
                string legionName = input[1];
                string soldierType = input[2];
                long soldierCount = long.Parse(input[3]);

                var currentLegion = new Legion
                {
                    Name = legionName,
                    LastActivity = lastActivity,
                    SoldiersTypes = new Dictionary<string, long>()
                };

                if (!legions.ContainsKey(legionName))
                {
                    legions[legionName] = currentLegion;
                }

                if (!legions[legionName].SoldiersTypes.ContainsKey(soldierType))
                {
                    legions[legionName].SoldiersTypes[soldierType] = 0;
                }

                legions[legionName].SoldiersTypes[soldierType] += soldierCount;

                if (legions.ContainsKey(legionName) && lastActivity > legions[legionName].LastActivity)
                {
                    legions[legionName].LastActivity = lastActivity;
                }
            }

            string command = Console.ReadLine();

            if (command.Contains(@"\"))
            {
                string[] input = command.Split("\\".ToCharArray(), StringSplitOptions.RemoveEmptyEntries);
                int lastActivity = int.Parse(input[0]);
                string soldierType = input[1];

                foreach (var kvp in legions
                    .Where(x => x.Value.LastActivity < lastActivity)
                    .Where(x => x.Value.SoldiersTypes.ContainsKey(soldierType))
                    .OrderByDescending(x => x.Value.SoldiersTypes[soldierType]))
                {
                    var currentLegion = kvp.Value;
                    long soldiers = currentLegion.SoldiersTypes[soldierType];
                    Console.WriteLine($"{currentLegion.Name} -> {soldiers}");
                }
            }
            else
            {
                string soldierType = command;

                foreach (var kvp in legions
                    .Where(x => x.Value.SoldiersTypes.ContainsKey(soldierType))
                    .OrderByDescending(x => x.Value.LastActivity))
                {
                    var currentLegion = kvp.Value;
                    Console.WriteLine($"{currentLegion.LastActivity} : {currentLegion.Name}");
                }
            }
        }
    }
}
