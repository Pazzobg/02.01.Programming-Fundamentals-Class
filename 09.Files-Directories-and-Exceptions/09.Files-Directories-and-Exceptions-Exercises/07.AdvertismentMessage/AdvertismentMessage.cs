namespace _07.AdvertismentMessage
{
    using System;
    using System.IO;

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

            var inputAsText = File.ReadAllText("input.txt");
            int n = int.Parse(inputAsText);

            var random = new Random();

            string result = string.Empty;

            for (int i = 0; i < n; i++)
            {
                int rndPhraseIndex = random.Next(0, phrase.Length);
                int rndEventIndex = random.Next(0, events.Length);
                int rndAuthorIndex = random.Next(0, author.Length);
                int rndCityIndex = random.Next(0, city.Length);

                result += $"{phrase[rndPhraseIndex]} {events[rndEventIndex]} {author[rndAuthorIndex]} - {city[rndCityIndex]}.{Environment.NewLine}";
            }

            File.WriteAllText("output.txt", result);
        }
    }
}
