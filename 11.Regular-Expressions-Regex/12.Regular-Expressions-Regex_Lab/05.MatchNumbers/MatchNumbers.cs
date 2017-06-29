namespace _05.MatchNumbers
{
    using System;
    using System.Linq;
    using System.Text.RegularExpressions;

    public class MatchNumbers
    {
        public static void Main()
        {
            string pattern = @"(^|(?<=\s))-?\d+(\.\d+)?($|(?=\s))";

            var regex = new Regex(pattern);

            string text = Console.ReadLine();

            var matches = regex.Matches(text).Cast<Match>().Select(m => m.Value).ToArray();
            Console.WriteLine(string.Join(" ", matches));
        }
    }
}
