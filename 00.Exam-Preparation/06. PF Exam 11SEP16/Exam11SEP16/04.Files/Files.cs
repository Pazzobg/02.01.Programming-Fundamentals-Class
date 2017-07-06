namespace _04.Files
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class Files
    {
        public static void Main()
        {
            var fileSystem = new Dictionary<string, Dictionary<string, long>>();

            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                string[] line = Console.ReadLine().Split(';');
                string path = line[0];
                long size = long.Parse(line[1]);

                string root = path.Split('\\').Take(1).ToArray()[0];
                string fileName = path.Split('\\').Reverse().Take(1).ToArray()[0].Trim();

                if (!fileSystem.ContainsKey(root))
                {
                    fileSystem[root] = new Dictionary<string, long>();
                }

                if (fileSystem[root].ContainsKey(fileName))
                {
                    fileSystem[root][fileName] = 0;
                }

                fileSystem[root][fileName] = size;
            }

            string[] commandLine = Console.ReadLine().Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);

            string extension = commandLine[0];
            string rootToScan = commandLine[2];
            bool found = false;

            foreach (var kvp in fileSystem.Where(k => k.Key == rootToScan))
            {
                string root = kvp.Key;
                var filesInThisRoot = kvp.Value;

                foreach (var innerKvp in filesInThisRoot
                    .Where(x => x.Key.EndsWith(extension))
                    .OrderByDescending(f => f.Value)
                    .ThenBy(f => f.Key))
                {
                    Console.WriteLine($"{innerKvp.Key} - {innerKvp.Value} KB");
                    found = true;
                }
            }

            if (!found)
            {
                Console.WriteLine("No");
            }
        }
    }
}
