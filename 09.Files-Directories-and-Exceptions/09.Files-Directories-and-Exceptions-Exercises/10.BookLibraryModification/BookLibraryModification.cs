namespace _10.BookLibraryModification
{
    using System;
    using System.Collections.Generic;
    using System.Globalization;
    using System.IO;
    using System.Linq;

    public class BookLibraryModification
    {
        public static void Main()
        {
            var library = new Dictionary<string, List<Book>>();

            string[] inputLines = File.ReadAllLines("input.txt");

            for (int i = 1; i < inputLines.Length - 1; i++)
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

            var booksReleasedAfterDate = DateTime
                .ParseExact(inputLines[inputLines.Length - 1], "dd.MM.yyyy", CultureInfo.InvariantCulture);

            var titlesDatesDict = new Dictionary<string, DateTime>();

            foreach (var kvp in library)
            {
                string authorName = kvp.Key;
                var authorsBooksList = kvp.Value;

                foreach (var book in authorsBooksList.Where(x => x.ReleaseDate > booksReleasedAfterDate))
                {
                    titlesDatesDict.Add(book.Title, book.ReleaseDate);
                }
            }

            string result = string.Empty;

            foreach (var titleDatePair in titlesDatesDict.OrderBy(x => x.Value).ThenBy(x => x.Key))
            {
                string title = titleDatePair.Key;
                DateTime date = titleDatePair.Value;

                result += $"{title} -> {date:dd.MM.yyyy} {Environment.NewLine}";
            }

            File.WriteAllText("output.txt", result);
        }
    }
}
