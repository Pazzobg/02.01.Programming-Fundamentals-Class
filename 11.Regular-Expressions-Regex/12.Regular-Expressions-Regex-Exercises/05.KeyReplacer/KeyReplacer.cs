namespace _05.KeyReplacer
{
    using System;
    using System.Text;
    using System.Text.RegularExpressions;

    public class KeyReplacer
    {
        public static void Main()
        {
            string keyText = Console.ReadLine();
            string keyPattern = @"^([A-Za-z]+)(\||<|\\).*?(\||<|\\)([A-Za-z]+)$";
            var regex = new Regex(keyPattern);

            var keyMatch = regex.Match(keyText);
            string extractionStart = keyMatch.Groups[1].Value.ToString();
            string extractionEnd = keyMatch.Groups[4].Value.ToString();

            string extractionPattern = $@"{extractionStart}(.*?){extractionEnd}";
            var extractionRegex = new Regex(extractionPattern);
            var sb = new StringBuilder();

            string text = Console.ReadLine();

            var matches = extractionRegex.Matches(text);

            foreach (Match match in matches)
            {
                sb.Append(match.Groups[1].Value.ToString());
            }

            Console.WriteLine(sb.Length > 0 ? sb.ToString() : "Empty result");
        }
    }
}
