namespace _06.FixEmails
{
    using System;
    using System.Collections.Generic;
    using System.IO;

    public class FixEmails
    {
        public static void Main()
        {
            var namesEmails = new Dictionary<string, string>();
            string lastNameEntered = string.Empty;

            string[] inputLines = File.ReadAllLines("input.txt");

            for (int i = 0; i < inputLines.Length - 1; i++)
            {
                string input = inputLines[i];

                if (i % 2 == 0)
                {
                    if (!namesEmails.ContainsKey(input))
                    {
                        namesEmails[input] = string.Empty;
                    }

                    lastNameEntered = input;
                }
                else
                {
                    string email = input;

                    if (email.EndsWith(".us") || email.EndsWith(".uk"))
                    {
                        namesEmails.Remove(lastNameEntered);
                        continue;
                    }
                    else
                    {
                        namesEmails[lastNameEntered] = email;
                    }
                }
            }

            string result = string.Empty;

            foreach (var kvp in namesEmails)
            {
                result += $"{kvp.Key} -> {kvp.Value}{Environment.NewLine}";
            }

            File.WriteAllText("output.txt", result);
        }
    }
}
