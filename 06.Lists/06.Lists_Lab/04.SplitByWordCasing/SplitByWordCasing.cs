namespace _04.SplitByWordCasing
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class SplitByWordCasing
    {
        public static void Main()
        {
            var words = Console.ReadLine().Split(
                new[] { ',', ';', ':', '.', '!', '(', ' ', ')', '"', '\'', '\\', '/', '[', ']' }, 
                StringSplitOptions.RemoveEmptyEntries)
                .ToList();

            var lowerCaseWords = new List<string>();
            var upperCaseWords = new List<string>();
            var mixedCaseWords = new List<string>();

            foreach (string word in words)
            {
                int counterLowerCase = 0;
                int counterUpperCase = 0;
                int counterMixedCase = 0;

                for (int i = 0; i < word.Length; i++)
                {
                    if (word[i] >= 65 && word[i] <= 90)
                    {
                        counterUpperCase++;
                    }
                    else if (word[i] >= 97 && word[i] <= 122)
                    {
                        counterLowerCase++;
                    }
                    else
                    {
                        counterMixedCase++;
                    }
                }

                if (counterUpperCase == 0 && counterMixedCase == 0)
                {
                    lowerCaseWords.Add(word);
                }
                else if (counterLowerCase == 0 && counterMixedCase == 0)
                {
                    upperCaseWords.Add(word);
                }
                else
                {
                    mixedCaseWords.Add(word);
                }
            }

            Console.WriteLine($"Lower-case: {string.Join(", ", lowerCaseWords)}");
            Console.WriteLine($"Mixed-case: {string.Join(", ", mixedCaseWords)}");
            Console.WriteLine($"Upper-case: {string.Join(", ", upperCaseWords)}");
        }
    }
}
