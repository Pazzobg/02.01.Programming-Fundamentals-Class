namespace _03.NetherRealms
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text.RegularExpressions;

    public class NetherRealms
    {
        public static void Main()
        {
            var participants = new List<Demon>();

            string[] input = Console.ReadLine().Split(',').Select(x => x.Trim()).ToArray();

            foreach (var name in input)
            {
                var regex = new Regex(@"[^\d./*+-]");
                var healthCalculation = regex.Matches(name);

                int health = 0;

                foreach (Match match in healthCalculation)
                {
                    health += char.Parse(match.Value);
                }

                regex = new Regex(@"(\+|-)?\d+(\.*(\d*))");
                var damageCalculation = regex.Matches(name);

                double damage = 0;

                foreach (Match match in damageCalculation)
                {
                    damage += double.Parse(match.Value);
                }

                regex = new Regex(@"[*/]");
                var damageMultiplication = regex.Matches(name);
                foreach (Match match in damageMultiplication)
                {
                    switch (match.Value.ToString())
                    {
                        case "*": damage *= 2; break;
                        case "/": damage /= 2; break;
                    }
                }

                var currentDemon = new Demon
                {
                    Name = name,
                    Health = health,
                    Damage = damage
                };

                participants.Add(currentDemon);
            }

            foreach (var demon in participants.OrderBy(d => d.Name))
            {
                Console.WriteLine($"{demon.Name} - {demon.Health} health, {demon.Damage:f2} damage");
            }
        }
    }
}
