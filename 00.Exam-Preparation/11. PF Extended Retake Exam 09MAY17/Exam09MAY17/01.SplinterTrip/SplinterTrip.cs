namespace _01.SplinterTrip
{
    using System;

    public class SplinterTrip
    {
        public static void Main()
        {
            double distanceInMiles = double.Parse(Console.ReadLine());
            double tankCapacity = double.Parse(Console.ReadLine());
            double milesInHeadWinds = double.Parse(Console.ReadLine());

            double tripFuel = ((distanceInMiles - milesInHeadWinds) * 25) + (milesInHeadWinds * (25 * 1.5));
            double totalTripFuel = tripFuel + (tripFuel * 0.05);
            Console.WriteLine($"Fuel needed: {totalTripFuel:f2}L");

            double diff = Math.Abs(totalTripFuel - tankCapacity);

            if (tankCapacity >= totalTripFuel)
            {
                Console.WriteLine($"Enough with {diff:f2}L to spare!");
            }
            else
            {
                Console.WriteLine($"We need {diff:f2}L more fuel.");
            }
        }
    }
}
