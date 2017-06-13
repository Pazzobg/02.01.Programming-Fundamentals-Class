namespace _11.StringConcatenation
{
    using System;

    public class StringConcatenation
    {
        public static void Main()
        {
            char delimiter = char.Parse(Console.ReadLine());
            string choice = Console.ReadLine();
            string builtLine = string.Empty;
            int n = int.Parse(Console.ReadLine());

            for (int i = 1; i <= n; i++)
            {
                string input = Console.ReadLine();

                bool even = i % 2 == 0;

                if (choice == "even" && !even)
                {
                    continue;
                }
                else if (choice == "odd" && even)
                {
                    continue;
                }

                builtLine += input;
                builtLine += delimiter;
            }

            string result = builtLine.Remove(builtLine.Length - 1);
            Console.WriteLine(result);
        }
    }
}