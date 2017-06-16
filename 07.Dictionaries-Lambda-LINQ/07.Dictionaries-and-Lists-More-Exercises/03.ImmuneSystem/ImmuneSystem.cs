namespace _03.ImmuneSystem
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class ImmuneSystem
    {
        public static void Main()
        {
            var virusesStoredInImmuneSystem = new List<string>();

            int initialHealth = int.Parse(Console.ReadLine());
            int health = initialHealth;

            string virus = Console.ReadLine();

            bool defeated = false;

            while (virus != "end")
            {
                bool virusEncountered = true;

                if (!virusesStoredInImmuneSystem.Contains(virus))
                {
                    virusesStoredInImmuneSystem.Add(virus);
                    virusEncountered = false;
                }

                int virusStrength = virus
                    .Select(x => (int)x)
                    .Sum()
                    / 3;

                int virusDefeatTotalSeconds = virusStrength * virus.Length;

                if (virusEncountered)
                {
                    virusDefeatTotalSeconds /= 3;
                }

                int defeatTimeMinutes = virusDefeatTotalSeconds / 60;
                int defatTimeSeconds = virusDefeatTotalSeconds % 60;

                health -= virusDefeatTotalSeconds;

                Console.WriteLine($"Virus {virus}: {virusStrength} => {virusDefeatTotalSeconds} seconds");

                if (health <= 0)
                {
                    defeated = true;
                    Console.WriteLine("Immune System Defeated.");
                    break;
                }
                else
                {
                    Console.WriteLine($"{virus} defeated in {defeatTimeMinutes}m {defatTimeSeconds}s.");
                    Console.WriteLine($"Remaining health: {health}");
                }

                health = Math.Min(initialHealth, (int)(health + (health * 0.2)));

                virus = Console.ReadLine();
            }

            if (!defeated)
            {
                Console.WriteLine($"Final Health: {health}");
            }
        }
    }
}
