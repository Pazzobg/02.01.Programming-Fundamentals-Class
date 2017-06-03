namespace _09.MakeAWord
{
    using System;

    public class MakeAWord
    {
        public static void Main()
        {
            int n = int.Parse(Console.ReadLine());
            string word = string.Empty;

            for (int i = 0; i < n; i++)
            {
                char currentChar = char.Parse(Console.ReadLine());
                word += currentChar;
            }

            Console.WriteLine($"The word is: {word}");
        }
    }
}