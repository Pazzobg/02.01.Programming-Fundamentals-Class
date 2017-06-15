namespace _06.UserLogs
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class UserLogs
    {
        public static void Main()
        {
            var usersDict = new SortedDictionary<string, Dictionary<string, int>>();

            string line = Console.ReadLine();

            while (line != "end")
            {
                string[] input = line.Split(' ');
                string ip = input[0].Split('=')[1];
                string message = input[1].Split('=')[1];
                string user = input[2].Split('=')[1];

                if (!usersDict.ContainsKey(user))
                {
                    usersDict[user] = new Dictionary<string, int>();
                }

                if (!usersDict[user].ContainsKey(ip))
                {
                    usersDict[user][ip] = 0;
                }

                usersDict[user][ip] += 1;

                line = Console.ReadLine();
            }

            foreach (var kvp in usersDict)
            {
                string userName = kvp.Key;
                var userLog = kvp.Value;

                Console.WriteLine($"{userName}: ");

                // The second foreach could be replaced by this: 
                //Console.WriteLine("{0}.", string.Join(", ", userLog.Select(kvp => $"{kvp.Key} => {kvp.Value}")));

                foreach (var kvp2 in userLog)
                {
                    string ip = kvp2.Key;
                    int messagesCount = kvp2.Value;

                    if (ip != userLog.Keys.Last())
                    {
                        Console.Write($"{ip} => {messagesCount}, ");
                    }
                    else
                    {
                        Console.WriteLine($"{ip} => {messagesCount}.");
                    }
                }
            }
        }
    }
}
