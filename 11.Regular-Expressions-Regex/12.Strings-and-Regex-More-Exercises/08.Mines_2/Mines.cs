namespace _08.Mines_2
{
    using System;
    using System.Text.RegularExpressions;

    public class Mines
    {
        public static void Main()
        {
            string input = Console.ReadLine();

            var regex = new Regex(@"<(.)(.)>");

            var matches = regex.Matches(input);

            foreach (Match match in matches)
            {
                int asciiValueOfFirstSymbol = match.Groups[1].Value[0];
                int asciiValueOfSecondSymbol = match.Groups[2].Value[0];
                int blastRadius = Math.Abs(asciiValueOfFirstSymbol - asciiValueOfSecondSymbol);

                string detonation = $@".{{0,{blastRadius}}}<..>.{{0,{blastRadius}}}";

                regex = new Regex(detonation);

                string devastatedAreas = regex.Match(input).ToString();

                input = input.Replace(devastatedAreas, new string('_', devastatedAreas.Length));
            }

            Console.WriteLine(input);
        }
    }
}
