namespace _01.SinoTheWalker
{
    using System;
    using System.Globalization;

    public class SinoTheWalker
    {
        public static void Main()
        {
            DateTime departureTime = DateTime.ParseExact(Console.ReadLine(), "HH:mm:ss", CultureInfo.InvariantCulture);

            double stepsToHome = double.Parse(Console.ReadLine()) % 86400; // 86400 seconds equal one day
            double secondsPerStep = double.Parse(Console.ReadLine()) % 86400;
            double totalSecondsToHome = stepsToHome * secondsPerStep;

            DateTime timeOfArrival = departureTime.AddSeconds(totalSecondsToHome);
            
            Console.WriteLine($"Time Arrival: {timeOfArrival:HH:mm:ss}");
        }
    }
}