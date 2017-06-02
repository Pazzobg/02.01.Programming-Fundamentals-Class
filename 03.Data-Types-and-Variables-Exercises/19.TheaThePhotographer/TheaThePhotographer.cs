namespace _19.TheaThePhotographer
{
    using System;

    public class TheaThePhotographer
    {
        public static void Main()
        {
            long photos = long.Parse(Console.ReadLine());
            long filterTimeSeconds = long.Parse(Console.ReadLine());
            long filterFactor = long.Parse(Console.ReadLine());
            long uploadTimeSeconds = long.Parse(Console.ReadLine());

            long filterAllPhotosSeconds = photos * filterTimeSeconds;
            long goodForUploadPics = (long)Math.Ceiling((photos * filterFactor) / 100d);
            long uploadGoodPhotosSeconds = goodForUploadPics * uploadTimeSeconds;
            long totalTimeSeconds = filterAllPhotosSeconds + uploadGoodPhotosSeconds;

            TimeSpan time = TimeSpan.FromSeconds(totalTimeSeconds);
            Console.WriteLine($"{time.Days:d1}:{time.Hours:d2}:{time.Minutes:d2}:{time.Seconds:d2}");


            long outputSecs = totalTimeSeconds % 60;
            long minutes = totalTimeSeconds / 60;
            long outputMinutes = minutes % 60;
            long hours = minutes / 60;
            long outputHours = hours % 24;
            long outputDays = hours / 24;

            Console.WriteLine($"{outputDays:0}:{outputHours:00}:{outputMinutes:00}:{outputSecs:00}");
        }
    }
}
