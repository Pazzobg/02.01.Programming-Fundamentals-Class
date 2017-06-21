namespace _09.TeamworkProjects
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class TeamworkProjects
    {
        public static void Main()
        {
            var teams = new Dictionary<string, Team>();

            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                string[] input = Console.ReadLine().Split('-');
                string creator = input[0];
                string teamName = input[1];

                var currentTeam = new Team
                {
                    Name = teamName,
                    Creator = creator,
                    Members = new List<string>
                    {
                        creator
                    }
                };

                if (teams.ContainsKey(teamName))
                {
                    Console.WriteLine($"Team {teamName} was already created!");
                }
                else if (teams.Any(x => x.Value.Creator == creator))
                {
                    Console.WriteLine($"{creator} cannot create another team!");
                }
                else
                {
                    teams.Add(teamName, currentTeam);
                    Console.WriteLine($"Team {teamName} has been created by {creator}!");
                }
            }

            string[] joiningMembers = Console.ReadLine()
                .Split("->".ToCharArray(), StringSplitOptions.RemoveEmptyEntries);

            while (joiningMembers[0] != "end of assignment")
            {
                string user = joiningMembers[0];
                string teamToJoinTo = joiningMembers[1];

                if (!teams.ContainsKey(teamToJoinTo))
                {
                    Console.WriteLine($"Team {teamToJoinTo} does not exist!");
                    joiningMembers = Console.ReadLine()
                        .Split("->".ToCharArray(), StringSplitOptions.RemoveEmptyEntries);
                    continue;
                }
                else if (teams.Any(x => x.Value.Members.Contains(user)))
                {
                    Console.WriteLine($"Member {user} cannot join team {teamToJoinTo}!");
                    joiningMembers = Console.ReadLine()
                        .Split("->".ToCharArray(), StringSplitOptions.RemoveEmptyEntries);
                    continue;
                }
                else
                {
                    teams[teamToJoinTo].Members.Add(user);
                }

                joiningMembers = Console.ReadLine().Split("->".ToCharArray(), StringSplitOptions.RemoveEmptyEntries);
            }

            foreach (var kvp in teams
                .Where(x => x.Value.Members.Count > 1)
                .OrderByDescending(x => x.Value.Members.Count)
                .ThenBy(x => x.Key))     // could be done also with SortedDictionary and without this sort
            {
                string teamName = kvp.Key;
                var team = kvp.Value;

                Console.WriteLine(teamName);
                Console.WriteLine($"- {team.Creator}");

                var membersListToSort = new List<string>();
                for (int i = 1; i < team.Members.Count; i++)
                {
                    membersListToSort.Add(team.Members[i]);
                }

                foreach (var member in membersListToSort.OrderBy(x => x))
                {
                    Console.WriteLine($"-- {member}");
                }
            }

            Console.WriteLine("Teams to disband:");

            foreach (var kvp in teams.Where(x => x.Value.Members.Count == 1).OrderBy(x => x.Key))
            {
                Console.WriteLine(kvp.Key);
            }
        }
    }
}
