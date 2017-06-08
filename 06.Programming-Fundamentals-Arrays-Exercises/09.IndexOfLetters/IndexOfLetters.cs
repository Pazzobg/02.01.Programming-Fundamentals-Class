namespace _09.IndexOfLetters
{
    using System;

    public class IndexOfLetters
    {
        public static void Main()
        {
            char[] lettersArr = new char[26];
            for (int i = 0; i < lettersArr.Length; i++)
            {
                lettersArr[i] = (char)(97 + i);
            }

            string word = Console.ReadLine();

            for (int i = 0; i < word.Length; i++)
            {
                char currentChar = word[i];

                for (int j = 0; j < lettersArr.Length; j++)
                {
                    if (currentChar == lettersArr[j])
                    {
                        Console.WriteLine($"{currentChar} -> {j}");
                    }
                }
            }
        }
    }
}
