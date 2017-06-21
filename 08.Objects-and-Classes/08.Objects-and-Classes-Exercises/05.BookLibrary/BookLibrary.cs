namespace _05.BookLibrary
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Globalization;

    public class BookLibrary
    {
        public static void Main()
        {
            Library myPreciousBooks = new Library();
            myPreciousBooks.BooksList = new List<Book>();
            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                string[] input = Console.ReadLine().Split(' ');

                Book currentBook = new Book
                {
                    Title = input[0],
                    Author = input[1],
                    Publisher = input[2],
                    ReleaseDate = DateTime.ParseExact(input[3], "d.M.yyyy", CultureInfo.InvariantCulture),
                    ISBN = input[4],
                    Price = decimal.Parse(input[5])
                };

                myPreciousBooks.BooksList.Add(currentBook);
            }

            var resultList = myPreciousBooks.BooksList
                .GroupBy(x => x.Author)
                .Select(g => new                        // ?!?wtf...
                {
                    Name = g.Key,
                    TotalRevenue = g.Sum(s => s.Price)
                })
                .OrderByDescending(x => x.TotalRevenue)
                .ThenBy(x => x.Name)
                .ToList();

            foreach (var author in resultList)
            {
                Console.WriteLine($"{author.Name} -> {author.TotalRevenue:f2}");
            }
        }
    }
}
