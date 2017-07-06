namespace _02.HornetComm
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Text.RegularExpressions;

    public class HornetComm
    {
        public static void Main()
        {
            var broadcastsDict = new Dictionary<string, List<string>>();
            var privateMessagesDict = new Dictionary<string, List<string>>();

            string patternPrivateMessage = @"^(\d+) <-> ([a-zA-Z0-9]+)$";
            string patternBroadcastMessage = @"^([\D]+) <-> ([a-zA-Z0-9]+)$";

            string input = Console.ReadLine();

            while (input != "Hornet is Green")
            {
                var matchPrivate = Regex.Match(input, patternPrivateMessage);
                var matchBroadcast = Regex.Match(input, patternBroadcastMessage);

                if (matchPrivate.Success)
                {
                    string recipient = matchPrivate.Groups[1].Value;
                    recipient = new string(recipient.Reverse().ToArray());
                    string message = matchPrivate.Groups[2].Value;

                    if (!privateMessagesDict.ContainsKey(recipient))
                    {
                        privateMessagesDict[recipient] = new List<string>();
                    }

                    privateMessagesDict[recipient].Add(message);
                }
                else if (matchBroadcast.Success)
                {
                    string message = matchBroadcast.Groups[1].Value;
                    string freq = matchBroadcast.Groups[2].Value;
                    var sb = new StringBuilder();

                    for (int i = 0; i < freq.Length; i++)
                    {
                        char currentChar = freq[i];

                        if (char.IsUpper(currentChar))
                        {
                            sb.Append(char.ToLower(currentChar));
                        }
                        else if (char.IsLower(currentChar))
                        {
                            sb.Append(char.ToUpper(currentChar));
                        }
                        else
                        {
                            sb.Append(currentChar);
                        }
                    }

                    string frequency = sb.ToString();

                    if (!broadcastsDict.ContainsKey(frequency))
                    {
                        broadcastsDict[frequency] = new List<string>();
                    }

                    broadcastsDict[frequency].Add(message);
                }

                input = Console.ReadLine();
            }

            Console.WriteLine("Broadcasts:");
            foreach (var kvp in broadcastsDict)
            {
                string freq = kvp.Key;
                var messages = kvp.Value;

                foreach (var message in messages)
                {
                    Console.WriteLine($"{freq} -> {message}");
                }
            }

            if (broadcastsDict.Count == 0)
            {
                Console.WriteLine("None");
            }

            Console.WriteLine("Messages:");
            foreach (var kvp in privateMessagesDict)
            {
                string recipient = kvp.Key;
                var messages = kvp.Value;

                foreach (var message in messages)
                {
                    Console.WriteLine($"{recipient} -> {message}");
                }
            }

            if (privateMessagesDict.Count == 0)
            {
                Console.WriteLine("None");
            }
        }
    }
}
