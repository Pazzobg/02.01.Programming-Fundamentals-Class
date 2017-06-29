namespace _02.MatchPhoneNumber
{
    using System;
    using System.Linq;
    using System.Text.RegularExpressions;

    public class MatchPhoneNumber
    {
        public static void Main()
        {
            string pattern = @"\+359(-| )2\1\d{3}\1\d{4}\b";

            var regex = new Regex(pattern);

            string text = Console.ReadLine();

            var numbersMatching = regex.Matches(text);

            var result = numbersMatching.Cast<Match>().Select(x => x.Value.Trim()).ToArray();

            Console.WriteLine(string.Join(", ", result));
        }
    }
}