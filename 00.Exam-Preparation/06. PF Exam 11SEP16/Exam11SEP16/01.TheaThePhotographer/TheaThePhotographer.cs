namespace _01.TheaThePhotographer
{
    using System;

    public class TheaThePhotographer
    {
        public static void Main()
        {
            long photosTaken = long.Parse(Console.ReadLine());
            int secondsToFilter = int.Parse(Console.ReadLine());
            int filterFactor = int.Parse(Console.ReadLine());
            int uploadSeconds = int.Parse(Console.ReadLine());

            long photosToUpload = (long)Math.Ceiling(photosTaken * (filterFactor / 100.0));
            long timeFilter = photosTaken * secondsToFilter;
            long totalTime = timeFilter + (photosToUpload * uploadSeconds);

            long seconds = totalTime % 60;
            long minutes = (totalTime / 60) % 60;
            long hours = (totalTime / 60 / 60) % 24;
            long days = (totalTime / 60 / 60) / 24;

            Console.WriteLine($"{days:d1}:{hours:d2}:{minutes:d2}:{seconds:d2}");
        }
    }
}
