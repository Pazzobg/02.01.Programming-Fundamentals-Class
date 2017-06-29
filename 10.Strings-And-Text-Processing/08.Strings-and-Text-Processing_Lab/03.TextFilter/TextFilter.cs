namespace _03.TextFilter
{
    using System;

    public class TextFilter
    {
        public static void Main()
        {
            string[] bannedWords = Console.ReadLine().Split(", ".ToCharArray(), StringSplitOptions.RemoveEmptyEntries);
            string text = Console.ReadLine();

            for (int i = 0; i < bannedWords.Length; i++)
            {
                string currentBanWord = bannedWords[i];

                text = text.Replace(currentBanWord, new string('*', currentBanWord.Length));
            }

            Console.WriteLine(text);
        }
    }
}
