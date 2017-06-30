namespace _02.ExtractSentencesByKeyword
{
    using System;
    using System.Linq;
    using System.Text.RegularExpressions;

    public class ExtractSentencesByKeyword
    {
        public static void Main()
        {
            var keyWord = Console.ReadLine();
            string pattern = $@"([a-zA-Z0-9,\s]+)\W{keyWord}\W.+?(\!|\.|\?)";
            var regex = new Regex(pattern);
            var text = Console.ReadLine();

            var matches = regex.Matches(text).Cast<Match>().Select(m => m.Value).ToArray();

            for (int i = 0; i < matches.Length; i++)
            {
                var sentence = matches[i];
                sentence = sentence.Remove(sentence.Length - 1);
                Console.WriteLine(sentence);
            }
        }
    }
}