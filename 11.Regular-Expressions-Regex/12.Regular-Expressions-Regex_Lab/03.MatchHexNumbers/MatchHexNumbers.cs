namespace _03.MatchHexNumbers
{
    using System;
    using System.Linq;
    using System.Text.RegularExpressions;

    public class MatchHexNumbers
    {
        public static void Main()
        {
            string pattern = @"\b(0x)?[0-9A-F]+\b";

            var regex = new Regex(pattern);

            var text = Console.ReadLine();

            var matchedHexes = regex.Matches(text).Cast<Match>().Select(x => x.Value).ToArray();

            Console.WriteLine(string.Join(" ", matchedHexes));
        }
    }
}
