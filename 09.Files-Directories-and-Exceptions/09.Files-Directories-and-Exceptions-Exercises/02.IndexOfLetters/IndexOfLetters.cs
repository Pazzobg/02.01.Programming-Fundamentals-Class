namespace _02.IndexOfLetters
{
    using System;
    using System.IO;

    public class IndexOfLetters
    {
        public static void Main()
        {
            //char[] alphabet = new char[26];

            //for (int i = 0; i < alphabet.Length; i++)
            //{
            //    alphabet[i] = (char)(i + 97);
            //}
            string[] inputLines = File.ReadAllLines("input.txt");
            string output = string.Empty;

            for (int i = 0; i < inputLines.Length; i++)
            {
                string currentWord = inputLines[i];

                char[] input = currentWord.ToCharArray();

                foreach (var character in input)
                {
                    output+= $"{character} -> {(int)(character - 97)}{Environment.NewLine}";
                }

                output += Environment.NewLine;
            }

            File.WriteAllText("output.txt", output);
        }
    }
}
