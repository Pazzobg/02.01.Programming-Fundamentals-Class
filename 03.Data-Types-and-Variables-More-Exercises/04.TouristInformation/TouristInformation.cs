namespace _04.TouristInformation
{
    using System;

    public class TouristInformation
    {
        public static void Main()
        {
            string imperialUnit = Console.ReadLine();
            double value = double.Parse(Console.ReadLine());
            string metricUnit = string.Empty;
            double result = 0;

            switch (imperialUnit)
            {
                case "miles":
                    result = value * 1.6;
                    metricUnit = "kilometers";
                    break;
                case "inches":
                    result = value * 2.54;
                    metricUnit = "centimeters";
                    break;
                case "feet":
                    result = value * 30;
                    metricUnit = "centimeters";
                    break;
                case "yards":
                    result = value * 0.91;
                    metricUnit = "meters";
                    break;
                default:
                    result = value * 3.8;
                    metricUnit = "liters";
                    break;
            }

            Console.WriteLine($"{value} {imperialUnit} = {result:f2} {metricUnit}");
        }
    }
}
