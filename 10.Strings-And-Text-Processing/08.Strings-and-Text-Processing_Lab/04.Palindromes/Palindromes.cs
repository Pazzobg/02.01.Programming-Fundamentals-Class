namespace _04.Palindromes
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;

    public class Palindromes
    {
        public static void Main()
        {
            string[] text = Console.ReadLine().Split(" ,.?!".ToCharArray(), StringSplitOptions.RemoveEmptyEntries);

            var palindromes = new SortedSet<string>();

            for (int i = 0; i < text.Length; i++)
            {
                string currentWord = text[i];

                bool isPalindrome = true;

                for (int j = 0; j < currentWord.Length / 2; j++)
                {
                    if (currentWord[j] != currentWord[currentWord.Length - 1 - j])
                    {
                        isPalindrome = false;
                        break;
                    }
                }

                if (isPalindrome)
                {
                    palindromes.Add(currentWord);
                }
            }

            Console.WriteLine(string.Join(", ", palindromes));
        }
    }
}
