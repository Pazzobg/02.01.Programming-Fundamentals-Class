namespace _03.RageQuit
{
    using System;
    using System.Linq;
    using System.Text;
    using System.Text.RegularExpressions;

    public class RageQuit
    {
        public static void Main()
        {
            var sb = new StringBuilder();

            string input = Console.ReadLine().ToUpper();

            string pattern = @"([^\d]+)(\d+)";
            var regex = new Regex(pattern);

            var matches = regex.Matches(input);

            foreach (Match match in matches)
            {
                string curseValue = match.Groups[1].Value;
                int curseRepetitionCount = int.Parse(match.Groups[2].Value);

                for (int i = 0; i < curseRepetitionCount; i++)
                {
                    sb.Append(curseValue);
                }
            }

            var finalCurse = sb.ToString();

            Console.WriteLine($"Unique symbols used: {finalCurse.Distinct().ToArray().Length}");
            Console.WriteLine(finalCurse);
        }
    }
}
