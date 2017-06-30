namespace _03.CameraView
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text.RegularExpressions;

    public class CameraView
    {
        public static void Main()
        {
            int[] textParams = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int toSkip = textParams[0];
            int toTake = textParams[1];
            string text = Console.ReadLine();

            var pattern = $@"(\|<)\w{{{toSkip}}}(?<foundMatch>\w{{1,{toTake}}})";
            var regex = new Regex(pattern);

            var matches = regex.Matches(text);
            var result = new List<string>();

            foreach (Match match in matches)
            {
                string word = match.Groups["foundMatch"].Value;
                result.Add(word);
            }

            Console.WriteLine(string.Join(", ", result));
        }
    }
}
