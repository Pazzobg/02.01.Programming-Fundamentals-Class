namespace _04.CubicMessages
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Text.RegularExpressions;

    public class CubicMessages
    {
        public static void Main()
        {
            var messagesFound = new List<string>();
            string messageLine = Console.ReadLine();

            while (messageLine != "Over!")
            {
                int exactLength = int.Parse(Console.ReadLine());

                string pattern = $@"^(\d+)([a-zA-Z]{{{exactLength}}})([^a-zA-Z]*?)$";
                var regex = new Regex(pattern);

                var match = regex.Match(messageLine);

                if (match.Success)
                {
                    messagesFound.Add(messageLine);
                }

                messageLine = Console.ReadLine();
            }

            for (int i = 0; i < messagesFound.Count; i++)
            {
                string currentMessage = messagesFound[i];

                string pattern = $@"^(\d+)([a-zA-Z]+)([^a-zA-Z]*?)$";
                var regex = new Regex(pattern);

                string messageText = regex.Match(currentMessage).Groups[2].Value;
                string digitsFront = regex.Match(currentMessage).Groups[1].Value;
                string symbolsBack = regex.Match(currentMessage).Groups[3].Value;

                regex = new Regex(@"\d");
                var indexes = new List<int>();
                indexes = regex.Matches(digitsFront).Cast<Match>().Select(x => x.Value).Select(int.Parse).ToList();
                indexes.AddRange(regex.Matches(symbolsBack).Cast<Match>().Select(x => x.Value).Select(int.Parse).ToList());

                var sb = new StringBuilder();

                for (int j = 0; j < indexes.Count; j++)
                {
                    if (indexes[j] >= 0 && indexes[j] < messageText.Length)
                    {
                        sb.Append(messageText[indexes[j]]);
                    }
                    else sb.Append(" ");
                }

                Console.WriteLine($"{messageText} == {sb.ToString()}");
            }
        }
    }
}
