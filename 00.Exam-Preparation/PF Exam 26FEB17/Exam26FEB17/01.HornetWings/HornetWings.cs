namespace _01.HornetWings
{
    using System;

    public class HornetWings
    {
        public static void Main()
        {
            double wingFlapsToDo = double.Parse(Console.ReadLine());
            double distanceMetersPerThousendFlaps = double.Parse(Console.ReadLine());
            int maxFlapsAtOnce = int.Parse(Console.ReadLine());

            double totalDistance = (wingFlapsToDo / 1000) * distanceMetersPerThousendFlaps;
            int totalSeconds = ((int)wingFlapsToDo / 100) + (((int)wingFlapsToDo / maxFlapsAtOnce) * 5);

            Console.WriteLine($"{totalDistance:f2} m.{Environment.NewLine}{totalSeconds} s.");
        }
    }
}
