namespace _02.ExtractSentencesByKeyword_2
{
    using System;
    using System.Text.RegularExpressions;

    public class ExtractSentencesByKeyword2
    {
        public static void Main()
        {
            var keyWord = Console.ReadLine();
            string pattern = @"([A-Z][\w\s,:;]+\W\b" + keyWord + @"\b\W.*?)[\.\!\?]{1}";
            var regex = new Regex(pattern);
            var text = Console.ReadLine();

            var matches = regex.Matches(text);

            foreach (Match match in matches)
            {
                Console.WriteLine(match.Groups[1].Value.ToString());
            }
        }
    }
}
