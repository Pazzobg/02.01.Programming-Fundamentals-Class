using System;

public class PhotoGallery
{
    public static void Main()
    {
        int photoNumber = int.Parse(Console.ReadLine());
        int day = int.Parse(Console.ReadLine());
        int month = int.Parse(Console.ReadLine());
        int year = int.Parse(Console.ReadLine());
        int hours = int.Parse(Console.ReadLine());
        int mins = int.Parse(Console.ReadLine());
        double sizeBytes = int.Parse(Console.ReadLine());
        int width = int.Parse(Console.ReadLine());
        int height = int.Parse(Console.ReadLine());

        double pictureSize = 0;
        string orientation = string.Empty;
        string sizeUnit = string.Empty;

        if (width > height)
        {
            orientation = "landscape";
        }
        else if (width < height)
        {
            orientation = "portrait";
        }
        else
        {
            orientation = "square";
        }

        if (sizeBytes < 1000)
        {
            pictureSize = sizeBytes;
            sizeUnit = "B";
        }
        else if (sizeBytes < 1000000)
        {
            pictureSize = sizeBytes / 1000;
            sizeUnit = "KB";
        }
        else
        {
            pictureSize = sizeBytes / 1000000;
            sizeUnit = "MB";
        }

        Console.WriteLine($"Name: DSC_{photoNumber:d4}.jpg");
        Console.WriteLine($"Date Taken: {day:d2}/{month:d2}/{year:d4} {hours:d2}:{mins:d2}"); 
        Console.WriteLine($"Size: {pictureSize}{sizeUnit}");
        Console.WriteLine($"Resolution: {width}x{height} ({orientation})");
    }
}