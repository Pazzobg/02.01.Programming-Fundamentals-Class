namespace _08.UseYourChainsBuddy
{
    using System;
    using System.Collections.Generic;
    using System.Text;
    using System.Text.RegularExpressions;

    public class UseYourChainsBuddy
    {
        public static void Main()
        {
            string extractionPattern = @"<p>(.*?)<\/p>";
            var regex = new Regex(extractionPattern);
            string text = Console.ReadLine();

            var matches = regex.Matches(text);
            var matchesToDecrypt = new List<string>();

            foreach (Match match in matches)
            {
                string replacementPattern = @"[^a-z0-9]+";
                string replacement = " ";

                regex = new Regex(replacementPattern);

                string resultWithSpaces = regex.Replace(match.Groups[1].Value.ToString(), replacement);

                matchesToDecrypt.Add(resultWithSpaces);
            }

            var sb = new StringBuilder();
            int difference = 13;
            var result = new List<string>();

            foreach (var word in matchesToDecrypt)
            {
                for (int i = 0; i < word.Length; i++)
                {
                    char currentLetter = word[i];

                    if (currentLetter >= 97 && currentLetter <= 109)
                    {
                        sb.Append(currentLetter += (char)difference);
                    }
                    else if (currentLetter >= 110 && currentLetter <= 122)
                    {
                        sb.Append(currentLetter -= (char)difference);
                    }
                    else
                    {
                        sb.Append(currentLetter);
                    }
                }

                result.Add(sb.ToString());
                sb.Clear();
            }

            Console.WriteLine(string.Join(string.Empty, result));
        }
    }
}
