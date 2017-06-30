namespace _07.QueryMess
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;
    using System.Text.RegularExpressions;

    public class QueryMess
    {
        public static void Main()
        {
            string input = Console.ReadLine();

            string pattern = @"([\w+%*\-\.()]+)=([\w+%*\-\.()]+)&?";
            var regex = new Regex(pattern);

            while (input != "END")
            {
                var outputDict = new Dictionary<string, List<string>>();

                var matches = regex.Matches(input);

                foreach (Match match in matches)
                {

                    string key = match.Groups[1].Value.ToString();
                    string value = match.Groups[2].Value.ToString();

                    if (key.Contains("%20"))
                    {
                        key = key.Remove(key.IndexOf("%20"), 3);
                    }
                    if (value.Contains("%20"))
                    {
                        value = value.Remove(value.IndexOf("%20"), 3);
                    }
                    if (key.Contains("+"))
                    {
                        key = key.Remove(key.IndexOf("+"), 1);
                    }
                    if (value.Contains("+"))
                    {
                        value = value.Remove(value.IndexOf("+"), 1);
                    }
                    if (key.ToLower() == "url" && value.ToLower().StartsWith("http"))
                    {
                        continue;
                    }

                    if (!outputDict.ContainsKey(key))
                    {
                        outputDict[key] = new List<string>();
                    }

                    outputDict[key].Add(value);
                }

                var sb = new StringBuilder();

                foreach (var kvp in outputDict)
                {
                    string key = kvp.Key;
                    var valuesList = kvp.Value;

                    sb.Append(key + "=[");
                    sb.Append(string.Join(", ", valuesList) + "]");
                }

                Console.WriteLine(sb.ToString());

                input = Console.ReadLine();
            }
        }
    }
}