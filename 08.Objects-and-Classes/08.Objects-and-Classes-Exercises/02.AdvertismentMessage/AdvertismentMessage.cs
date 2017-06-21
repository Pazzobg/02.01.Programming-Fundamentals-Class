namespace _02.AdvertismentMessage
{
    using System;

    public class AdvertismentMessage
    {
        public static void Main()
        {
            string[] phrase = new string[]
            {
                "Excellent product.",
                "Such a great product.",
                "I always use that product.",
                "Best product of its category.",
                "Exceptional product.",
                "I can’t live without this product."
            };

            string[] events = new string[]
            {
                "Now I feel good",
                "I have succeeded with this product.",
                "Makes miracles. I am happy of the results!",
                "I cannot believe but now I feel awesome.",
                "Try it yourself, I am very satisfied.",
                "I feel great!"
            };

            string[] author = new string[]
            {
                "Diana",
                "Petya",
                "Stella",
                "Elena",
                "Katya",
                "Iva",
                "Annie",
                "Eva"
            };

            string[] city = new string[]
            {
                "Sofia",
                "Plovdiv",
                "Varna",
                "Burgas",
                "Ruse"
            };

            int numberOfMessages = int.Parse(Console.ReadLine());

            Random randomNum = new Random();

            for (int i = 0; i < numberOfMessages; i++)
            {
                int randomPhrase = randomNum.Next(0, phrase.Length);
                int randomEvent = randomNum.Next(0, events.Length);
                int randomAuthor = randomNum.Next(0, author.Length);
                int randomCity = randomNum.Next(0, city.Length);

                Console.WriteLine(
                    "{0} {1} {2} – {3}",
                    phrase[randomPhrase],
                    events[randomEvent],
                    author[randomAuthor],
                    city[randomCity]);
            }
        }
    }
}