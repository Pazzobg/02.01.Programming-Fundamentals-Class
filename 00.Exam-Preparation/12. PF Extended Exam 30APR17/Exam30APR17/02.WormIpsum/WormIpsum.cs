namespace _02.WormIpsum
{
    using System;
    using System.Linq;
    using System.Text.RegularExpressions;

    public class WormIpsum
    {
        public static void Main()
        {
            string pattern = @"^[A-Z].*?\.$";
            var regex = new Regex(pattern);
            var regexWords = new Regex(@"\b[\w]+\b");

            string line = Console.ReadLine();

            while (line != "Worm Ipsum")
            {
                var sentenceMatch = regex.Match(line);

                if (!sentenceMatch.Success)
                {
                    line = Console.ReadLine();
                    continue;
                }

                int countDots = 0;

                for (int i = 0; i < line.Length; i++)
                {
                    if (line[i] == '.')
                    {
                        countDots++;
                    }
                }

                if (countDots > 1)
                {
                    line = Console.ReadLine();
                    continue;
                }

                var words = regexWords.Matches(line).Cast<Match>().Select(x => x.Value).ToArray();

                foreach (string word in words)
                {
                    char mostRepeatedChar = '\0';
                    int countMostRepeatedChar = 1;

                    for (int j = 0; j < word.Length; j++)
                    {
                        char currentChar = word[j];
                        int currentCount = word.Where(x => x == currentChar).Count();

                        if (currentCount > countMostRepeatedChar)
                        {
                            countMostRepeatedChar = currentCount;
                            mostRepeatedChar = currentChar;
                        }
                    }

                    if (countMostRepeatedChar > 1)
                    {
                        string wordToReplace = new string(mostRepeatedChar, word.Length);
                        line = Regex.Replace(line, word, wordToReplace);
                    }
                }

                Console.WriteLine(line);

                line = Console.ReadLine();
            }
        }
    }
}
