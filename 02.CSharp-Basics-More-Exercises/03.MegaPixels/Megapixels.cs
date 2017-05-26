using System;

public class Megapixels
{
    public static void Main()
    {
        double width = double.Parse(Console.ReadLine()); ;
        int height = int.Parse(Console.ReadLine());

        double pixels = width * height;

        double megaPixels = Math.Round(pixels / 1000000, 1);

        Console.WriteLine($"{width}x{height} => {megaPixels}MP");
    }
}