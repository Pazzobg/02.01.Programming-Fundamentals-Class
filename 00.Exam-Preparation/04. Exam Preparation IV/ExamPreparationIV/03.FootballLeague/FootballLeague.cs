namespace _03.FootballLeague
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Text.RegularExpressions;

    public class FootballLeague
    {
        public static void Main()
        {
            var scoresTable = new Dictionary<string, int>();
            var goalsTable = new SortedDictionary<string, long>();

            string delimiter = Console.ReadLine();
            delimiter = Regex.Escape(delimiter);
            string input = Console.ReadLine();

            while (input != "final")
            {
                string pattern = $@".*?(?:{delimiter})(.*?)(?:{delimiter}).*?(?:{
                    delimiter})(.*?)(?:{delimiter}).*?(\d+):(\d+)";
                var regex = new Regex(pattern);

                string first = regex.Match(input).Groups[1].Value.ToUpper();
                string firstTeamName = GetTeamName(first);  // one option to get it
                string second = regex.Match(input).Groups[2].Value.ToUpper();  // another option to get it
                var secondName = second.ToCharArray().Reverse().ToArray();
                string secondTeamName = new string(secondName);

                int firstTeamGoals = int.Parse(regex.Match(input).Groups[3].Value);
                int secondTeamGoals = int.Parse(regex.Match(input).Groups[4].Value);

                int firstTeamScore = 0;
                int secondTeamScore = 0;

                if (firstTeamGoals > secondTeamGoals)
                {
                    firstTeamScore = 3;
                }
                else if (secondTeamGoals > firstTeamGoals)
                {
                    secondTeamScore = 3;
                }
                else
                {
                    firstTeamScore = 1;
                    secondTeamScore = 1;
                }

                if (!scoresTable.ContainsKey(firstTeamName))
                {
                    scoresTable[firstTeamName] = 0;
                }
                scoresTable[firstTeamName] += firstTeamScore;

                if (!goalsTable.ContainsKey(firstTeamName))
                {
                    goalsTable[firstTeamName] = 0;
                }
                goalsTable[firstTeamName] += firstTeamGoals;

                if (!scoresTable.ContainsKey(secondTeamName))
                {
                    scoresTable[secondTeamName] = 0;
                }
                scoresTable[secondTeamName] += secondTeamScore;

                if (!goalsTable.ContainsKey(secondTeamName))
                {
                    goalsTable[secondTeamName] = 0;
                }
                goalsTable[secondTeamName] += secondTeamGoals;

                input = Console.ReadLine();
            }

            Console.WriteLine("League standings:");
            int j = 1;
            foreach (var kvp in scoresTable.OrderByDescending(x => x.Value).ThenBy(t => t.Key))
            {
                Console.WriteLine($"{j}. {kvp.Key} {kvp.Value}");
                j++;
            }

            Console.WriteLine("Top 3 scored goals:");
            foreach (var kvp in goalsTable.OrderByDescending(x => x.Value).Take(3))
            {
                Console.WriteLine($"- {kvp.Key} -> {kvp.Value}");
            }
        }

        public static string GetTeamName(string team)
        {
            var sb = new StringBuilder();

            for (int i = team.Length - 1; i >= 0; i--)
            {
                sb.Append(team[i]);
            }

            return sb.ToString();
        }
    }
}
