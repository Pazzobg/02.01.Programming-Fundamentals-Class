namespace _04.FixEmails_2
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class FixEmails
    {
        public static void Main()
        {
            var usersEmails = new Dictionary<string, string>();

            string line = Console.ReadLine();

            while (line != "stop")
            {
                string name = line;
                string email = Console.ReadLine();

                if (!usersEmails.ContainsKey(name))
                {
                    usersEmails[name] = string.Empty;
                }

                usersEmails[name] = email;

                line = Console.ReadLine();
            }

            foreach (var kvp in usersEmails
                .Where(kvp => !(kvp.Value.EndsWith(".us") || kvp.Value.EndsWith(".uk"))))
            {
                string name = kvp.Key;
                string emailAddress = kvp.Value;
                Console.WriteLine($"{name} -> {emailAddress}");
            }
        }
    }
}
