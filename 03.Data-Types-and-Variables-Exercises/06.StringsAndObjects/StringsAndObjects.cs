namespace _06.StringsAndObjects
{
    using System;

    public class StringsAndObjects
    {
        public static void Main()
        {
            string word1 = "Hello";
            string word2 = "World";
            object line = $"{word1} {word2}";
            string result = (string)line;
            Console.WriteLine(result);
        }
    }
}
