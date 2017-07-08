namespace _04.WormsWorldsParty
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class WormsWorldsParty
    {
        public static void Main()
        {
            var wormsTeams = new Dictionary<string, Dictionary<string, long>>();
            var namesList = new List<string>();

            string[] input = Console.ReadLine()
                .Split("->".ToCharArray(), StringSplitOptions.RemoveEmptyEntries)
                .Select(s => s.Trim())
                .ToArray();

            while (input[0] != "quit")
            {
                string wormName = input[0];
                string team = input[1];
                long playerScore = long.Parse(input[2]);

                if (!namesList.Contains(wormName))
                {
                    if (!wormsTeams.ContainsKey(team))
                    {
                        wormsTeams[team] = new Dictionary<string, long>();
                    }

                    wormsTeams[team][wormName] = playerScore;
                    namesList.Add(wormName);
                }

                input = Console.ReadLine()
                .Split("->".ToCharArray(), StringSplitOptions.RemoveEmptyEntries)
                .Select(s => s.Trim())
                .ToArray();
            }

            long teamPosition = 1;

            foreach (var team in wormsTeams.OrderByDescending(x => x.Value.Values.Sum()).ThenByDescending(x => x.Value.Values.Average()))
            {
                string teamName = team.Key;
                var players = team.Value;
                long totalTeamScore = players.Sum(x => x.Value);

                Console.WriteLine($"{teamPosition}. Team: {teamName} - {totalTeamScore}");

                foreach (var player in players.OrderByDescending(x => x.Value))
                {
                    string name = player.Key;
                    long score = player.Value;

                    Console.WriteLine($"###{name} : {score}");
                }

                teamPosition++;
            }
        }
    }
}
