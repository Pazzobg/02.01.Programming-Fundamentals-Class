namespace _06.ReplaceTag
{
    using System;
    using System.Collections.Generic;
    using System.Text.RegularExpressions;

    public class ReplaceTag
    {
        public static void Main()
        {
            string pattern = @"<a.*?href=(""|')(.*)\1>(.*?)<\/a>";
            var regex = new Regex(pattern);

            string input = Console.ReadLine();
            var lines = new List<string>();

            var matches = regex.Matches(input);

            while (input != "end")
            {
                if (regex.IsMatch(input))
                {
                    var result = regex.Replace(input, "[URL href=\"$2\"]$3[/URL]");
                    lines.Add(result);
                }
                else
                {
                    lines.Add(input);
                }

                input = Console.ReadLine();
            }

            foreach (var line in lines)
            {
                Console.WriteLine(line);
            }
        }
    }
}
