namespace _06.EmailStatistics
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text.RegularExpressions;

    public class EmailStatistics
    {
        public static void Main()
        {
            int n = int.Parse(Console.ReadLine());

            var usersDomainsDict = new Dictionary<string, List<string>>();

            var regex = new Regex(@"^([A-Za-z]{5,})@([a-z]{3,}\.(com|bg|org))$");

            for (int i = 0; i < n; i++)
            {
                string input = Console.ReadLine();

                var currentMatch = regex.Match(input);

                if (!currentMatch.Success)
                {
                    continue;
                }

                string domain = currentMatch.Groups[2].Value;
                string username = currentMatch.Groups[1].Value;

                if (!usersDomainsDict.ContainsKey(domain))
                {
                    usersDomainsDict[domain] = new List<string>();
                }

                if (!usersDomainsDict[domain].Contains(username))
                {
                    usersDomainsDict[domain].Add(username);
                }
            }

            foreach (var domain in usersDomainsDict.OrderByDescending(x => x.Value.Count))
            {
                string domainName = domain.Key;
                var usernames = domain.Value;

                Console.WriteLine($"{domainName}:");

                foreach (var name in usernames)
                {
                    Console.WriteLine($"### {name}");
                }
            }
        }
    }
}
