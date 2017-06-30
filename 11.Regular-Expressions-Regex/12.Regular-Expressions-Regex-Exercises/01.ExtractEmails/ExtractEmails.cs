namespace _01.ExtractEmails
{
    using System;
    using System.Text.RegularExpressions;

    public class ExtractEmails
    {
        public static void Main()
        {
            var pattern = @"(^|(?<=\s))[a-zA-Z0-9]+(\.?|-?|_?)[a-zA-Z0-9]+@([a-zA-Z0-9]+-?[a-zA-Z0-9]+\.)[a-zA-Z0-9]+(\.[a-zA-Z0-9]+)*";
            var regex = new Regex(pattern);

            var input = Console.ReadLine();

            var matches = regex.Matches(input);

            foreach (Match match in matches)
            {
                Console.WriteLine(match);
            }
        }
    }
}
