namespace _01.MatchFullName
{
    using System;
    using System.Text.RegularExpressions;

    public class MatchFullName
    {
        public static void Main()
        {
            var pattern = @"\b[A-Z][a-z]+ [A-Z][a-z]+\b";

            var regex = new Regex(pattern);

            string text = Console.ReadLine();

            var matches = regex.Matches(text);

            foreach (Match name in matches)
            {
                Console.Write($"{name} ");
            }
        }
    }
}
