namespace _02.CircleAreaPrecisionTwelve
{
    using System;

    public class CircleAreaPrecision12
    {
        public static void Main()
        {
            double r = double.Parse(Console.ReadLine());    // radius of circle
            Console.WriteLine("{0:f12}", Math.PI * r * r);
        }
    }
}