namespace _03.WordsCount
{
    using System;
    using System.Collections.Generic;
    using System.IO;
    using System.Linq;

    public class WordsCount
    {
        public static void Main()
        {
            string[] words = File.ReadAllText(@"D:\SoftUni\...\Resources\03. Word Count\words.txt")
                .ToLower()
                .Split(' ');
            string[] text = File.ReadAllText(@"D:\SoftUni\...\Resources\03. Word Count\text.txt")
                .ToLower()
                .Split(" -,.?!\r\n".ToCharArray(), StringSplitOptions.RemoveEmptyEntries);

            var output = new Dictionary<string, int>();

            for (int i = 0; i < words.Length; i++)
            {
                string currentWord = words[i];
                int counter = 0;

                for (int j = 0; j < text.Length; j++)
                {
                    if (currentWord == text[j])
                    {
                        counter++;
                    }
                }

                output[currentWord] = counter;
            }

            string outputString = string.Empty;

            foreach (var kvp in output.OrderByDescending(x => x.Value))
            {
                outputString += $"{kvp.Key} - {kvp.Value}\r\n";
            }

            File.WriteAllText("OutputFoundWordsCount.txt", outputString);
        }
    }
}