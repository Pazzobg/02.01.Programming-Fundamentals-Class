namespace _02.SpyGram
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;
    using System.Text.RegularExpressions;

    public class SpyGram
    {
        public static void Main()
        {
            var pendingMessages = new SortedDictionary<string, List<string>>();
            string pattern = @"TO: ([A-Z]+); MESSAGE: (.*);"; // Greedy or non-greedy?: TO: ([A-Z]+); MESSAGE: (.*?);
            var regex = new Regex(pattern);
            string key = Console.ReadLine();
            string input = Console.ReadLine();

            while (input != "END")
            {
                var match = regex.Match(input);

                if (!match.Success)
                {
                    input = Console.ReadLine();
                    continue;
                }

                string recepientName = match.Groups[1].Value;

                string encryptedMessage = EncryptMessage(input, key);

                if (!pendingMessages.ContainsKey(recepientName))
                {
                    pendingMessages[recepientName] = new List<string>();
                }

                pendingMessages[recepientName].Add(encryptedMessage);
                
                input = Console.ReadLine();
            }

            foreach (var kvp in pendingMessages)
            {
                foreach (var message in kvp.Value)
                {
                    Console.WriteLine(message);
                }
            }
        }

        private static string EncryptMessage(string input, string key)
        {
            var sb = new StringBuilder();
            for (int i = 0; i < input.Length; i++)
            {
                int currentKeyIndex = i % key.Length;

                char currentSymbol = input[i];
                int shift = int.Parse(key[currentKeyIndex].ToString());

                sb.Append((char)(currentSymbol + shift));
            }
            
            return sb.ToString();
        }
    }
}
