namespace _07.Hideout
{
    using System;
    using System.Text.RegularExpressions;

    public class Hideout
    {
        public static void Main()
        {
            string map = Console.ReadLine();

            while (true)
            {
                string[] clues = Console.ReadLine().Split(' ');

                string searchedCharacter = clues[0];
                int minimumCount = int.Parse(clues[1]);

                var regex = new Regex($@"\{searchedCharacter}{{{minimumCount},}}");

                var match = regex.Match(map);

                if (match.Success)
                {
                    Console.WriteLine($"Hideout found at index {match.Index} and it is with size {match.Length}!");
                    break;
                }
            }
        }
    }
}
