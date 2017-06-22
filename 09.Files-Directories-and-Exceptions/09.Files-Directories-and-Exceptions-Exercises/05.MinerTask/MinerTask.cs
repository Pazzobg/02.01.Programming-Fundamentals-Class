namespace _05.MinerTask
{
    using System;
    using System.Collections.Generic;
    using System.IO;
    using System.Linq;

    public class MinerTask
    {
        public static void Main()
        {
            string[] inputLines = File.ReadAllLines("input.txt");

            var resources = new Dictionary<string, long>();
            string lastResourceName = string.Empty;

            for (int i = 0; i < inputLines.Length - 1; i++)
            {
                string input = inputLines[i];

                if (i % 2 == 0)
                {
                    if (!resources.ContainsKey(input))
                    {
                        resources[input] = 0;
                    }

                    lastResourceName = input;
                }
                else
                {
                    int quantity = int.Parse(input);

                    resources[lastResourceName] += quantity;
                }
            }

            string result = string.Empty;

            foreach (var kvp in resources)
            {
                result += $"{kvp.Key} -> {kvp.Value}{Environment.NewLine}";
            }

            File.WriteAllText("output.txt", result);
        }
    }
}
