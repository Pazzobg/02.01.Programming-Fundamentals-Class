namespace _01.Censorship
{
    using System;

    public class Censorship
    {
        public static void Main()
        {
            string word = Console.ReadLine();
            string text = Console.ReadLine();

            Console.WriteLine(text.Replace(word, new string('*', word.Length)));
        }
    }
}
