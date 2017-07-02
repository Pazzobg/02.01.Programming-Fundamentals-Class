namespace _05.OnlyLetters
{
    using System;
    using System.Text.RegularExpressions;

    public class OnlyLetters
    {
        public static void Main()
        {
            var input = Console.ReadLine();

            var regex = new Regex(@"(\d+)([A-Za-z])");

            var matches = regex.Matches(input);

            foreach (Match match in matches)
            {
                input = Regex.Replace(input, match.Groups[1].Value, match.Groups[2].Value);
            }

            Console.WriteLine(input);
        }
    }
}
