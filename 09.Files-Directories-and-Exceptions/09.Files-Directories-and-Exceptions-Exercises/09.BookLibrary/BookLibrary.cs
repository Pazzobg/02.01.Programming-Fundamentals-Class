namespace _09.BookLibrary
{
    using System;
    using System.Collections.Generic;
    using System.Globalization;
    using System.IO;
    using System.Linq;

    public class BookLibrary
    {
        public static void Main()
        {
            var library = new Dictionary<string, List<Book>>();

            string[] inputLines = File.ReadAllLines("input.txt");

            for (int i = 1; i < inputLines.Length; i++)
            {
                string[] input = inputLines[i].Split(' ');

                string currentTitle = input[0];
                string currentAuthor = input[1];
                string currentPublisher = input[2];
                DateTime currentReleaseDate = DateTime.ParseExact(input[3], "dd.MM.yyyy", CultureInfo.InvariantCulture);
                string currentIsbn = input[4];
                decimal currentPrice = decimal.Parse(input[5]);

                var book = new Book
                {
                    Title = currentTitle,
                    Author = currentAuthor,
                    Publisher = currentPublisher,
                    ReleaseDate = currentReleaseDate,
                    Isbn = currentIsbn,
                    Price = currentPrice
                };

                if (!library.ContainsKey(currentAuthor))
                {
                    library[currentAuthor] = new List<Book>();
                }

                library[currentAuthor].Add(book);
            }

            var authorsMoneyDict = new Dictionary<string, decimal>();

            foreach (var author in library)
            {
                string authorName = author.Key;
                decimal totalMoney = author.Value.Select(x => x.Price).Sum();

                authorsMoneyDict.Add(authorName, totalMoney);
            }

            string result = string.Empty;

            foreach (var entry in authorsMoneyDict.OrderByDescending(x => x.Value).ThenBy(x => x.Key))
            {
                result += $"{entry.Key} -> {entry.Value:f2}{Environment.NewLine}";
            }

            File.WriteAllText("output.txt", result);
        }
    }
}
