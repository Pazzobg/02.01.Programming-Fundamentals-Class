namespace _04.PunctuationFinder
{
    using System.Collections.Generic;
    using System.IO;

    public class PunctualtionFinder
    {
        public static void Main()
        {
            var text = File.ReadAllText("D:\\SoftUni\\...\\sample_text.txt");

            var result = new List<char>();

            foreach (var c in text)
            {
                if (c == '.' || c == ',' || c == '!' || c == '?' || c == ':')
                {
                    result.Add(c);
                }
            }

            File.WriteAllText("output.txt", string.Join(", ", result));
        }
    }
}
