namespace _11.ConvertSpeedUnits
{
    using System;

    public class ConvertSpeedUnits
    {
        public static void Main()
        {
            float meters = float.Parse(Console.ReadLine());
            float hours = float.Parse(Console.ReadLine());
            float mins = float.Parse(Console.ReadLine());
            float secs = float.Parse(Console.ReadLine());
            float distanceKm = meters / 1000;
            float distanceMi = meters / 1609;

            float timeInSeconds = (((hours * 60) + mins) * 60) + secs;
            float timeInHours = (((secs / 60) + mins) / 60) + hours;

            float speedMetersPerSecond = meters / timeInSeconds;
            float speedKmPerHour = distanceKm / timeInHours;
            float speedMiPerHour = distanceMi / timeInHours;

            Console.WriteLine($"{speedMetersPerSecond}\n{speedKmPerHour}\n{speedMiPerHour}");
        }
    }
}
