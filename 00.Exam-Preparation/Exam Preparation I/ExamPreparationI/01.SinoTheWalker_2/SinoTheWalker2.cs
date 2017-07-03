namespace _01.SinoTheWalker_2
{
    using System;
    using System.Numerics;

    public class SinoTheWalker2
    {
        public static void Main()
        {
            string[] timeDep = Console.ReadLine().Split(':');
            int hours = int.Parse(timeDep[0]) * 60 * 60;
            int mins = int.Parse(timeDep[1]) * 60;
            int secs = int.Parse(timeDep[2]);
            int totalSecsDeparture = hours + mins + secs;

            BigInteger stepsToHome = BigInteger.Parse(Console.ReadLine());
            int secondsPerStep = int.Parse(Console.ReadLine());
            BigInteger totalSecondsToHome = stepsToHome * secondsPerStep;

            BigInteger endTime = totalSecsDeparture + totalSecondsToHome;

            BigInteger leftoverFromDays = endTime % 86400;

            BigInteger totalHours = leftoverFromDays / 3600;
            BigInteger totalMins = (leftoverFromDays % 3600) / 60;
            BigInteger totalSecs = (leftoverFromDays % 3600) % 60;

            Console.WriteLine($"Time Arrival: {totalHours:00}:{totalMins:00}:{totalSecs:00}");
        }
    }
}
