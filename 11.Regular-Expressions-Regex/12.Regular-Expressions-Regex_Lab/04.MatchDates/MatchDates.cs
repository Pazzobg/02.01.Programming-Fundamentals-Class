namespace _04.MatchDates
{
    using System;
    using System.Text.RegularExpressions;

    public class MatchDates
    {
        public static void Main()
        {
            string pattern = @"\b(\d{2})(-|.|\/)([A-Z][a-z]{2})\2(\d{4})\b";

            var regex = new Regex(pattern);

            string text = Console.ReadLine();

            var matches = regex.Matches(text);

            foreach (Match date in matches)
            {
                string day = date.Groups[1].Value;
                string month = date.Groups[3].Value;
                string year = date.Groups[4].Value;
                Console.WriteLine($"Day: {day}, Month: {month}, Year: {year}");
            }
        }
    }
}
