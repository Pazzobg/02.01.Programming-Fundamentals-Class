namespace _08.LogsAggregator
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class LogsAggregator
    {
        public static void Main()
        {
            var usersDict = new SortedDictionary<string, SortedDictionary<string, int>>();

            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                string[] input = Console.ReadLine().Split(' ');
                string userName = input[1];
                string ip = input[0];
                int duration = int.Parse(input[2]);

                if (!usersDict.ContainsKey(userName))
                {
                    usersDict[userName] = new SortedDictionary<string, int>();
                }

                if (!usersDict[userName].ContainsKey(ip))
                {
                    usersDict[userName][ip] = 0;
                }

                usersDict[userName][ip] += duration;
            }

            foreach (var kvp in usersDict)
            {
                string user = kvp.Key;
                var logData = kvp.Value;

                Console.WriteLine($"{user}: {logData.Values.Sum()} [{string.Join(", ", logData.Keys.Distinct())}]");
            }
        }
    }
}
