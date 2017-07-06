namespace _02.SoftUniKaraoke
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class SoftUniKaraoke
    {
        public static void Main()
        {
            var singersAndAwards = new SortedDictionary<string, SortedSet<string>>();

            string[] singers = Console.ReadLine().Split(',').Select(s => s.Trim()).ToArray();
            string[] songs = Console.ReadLine().Split(',').Select(s => s.Trim()).ToArray();

            string[] input = Console.ReadLine().Split(',').Select(x => x.Trim()).ToArray();

            while (input[0] != "dawn")
            {
                string currentSinger = input[0];
                string currentSong = input[1];
                string award = input[2];

                if (!singers.Contains(currentSinger) || !songs.Contains(currentSong))
                {
                    input = Console.ReadLine().Split(',').Select(x => x.Trim()).ToArray();
                    continue;
                }

                if (!singersAndAwards.ContainsKey(currentSinger))
                {
                    singersAndAwards[currentSinger] = new SortedSet<string>();
                }

                singersAndAwards[currentSinger].Add(award);

                input = Console.ReadLine().Split(',').Select(x => x.Trim()).ToArray();
            }

            if (!singersAndAwards.Any())
            {
                Console.WriteLine("No awards");
            }
            else
            {
                foreach (var kvp in singersAndAwards.OrderByDescending(x => x.Value.Count))
                {
                    string singer = kvp.Key;
                    var awards = kvp.Value;

                    Console.WriteLine($"{singer}: {awards.Count} awards");

                    foreach (string award in awards)
                    {
                        Console.WriteLine($"--{award}");
                    }
                }
            }
        }
    }
}
