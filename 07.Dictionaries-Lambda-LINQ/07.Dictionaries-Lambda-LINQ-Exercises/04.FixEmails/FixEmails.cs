namespace _04.FixEmails
{
    using System;
    using System.Collections.Generic;

    public class FixEmails
    {
        public static void Main()
        {
            var emails = new Dictionary<string, string>();

            while (true)
            {
                string name = Console.ReadLine();
                if (name == "stop") break;

                string email = Console.ReadLine();
                if (email.EndsWith(".us") || email.EndsWith(".uk")) continue;

                if (!emails.ContainsKey(name))
                {
                    emails[name] = string.Empty;
                }

                emails[name] = email;
            }

            foreach (var kvp in emails)
            {
                Console.WriteLine($"{kvp.Key} -> {kvp.Value}");
            }
        }
    }
}
