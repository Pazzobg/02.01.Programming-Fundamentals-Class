namespace _03.EnduranceRally
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class EnduranceRally
    {
        public static void Main()
        {
            var drivers = new List<Driver>();

            string[] names = Console.ReadLine().Split(' ');
            double[] track = Console.ReadLine().Split(' ').Select(double.Parse).ToArray();
            int[] checkPoints = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();

            for (int i = 0; i < names.Length; i++)
            {
                string currentDriver = names[i];
                double fuel = currentDriver[0];

                var driver = new Driver
                {
                    Name = currentDriver,
                    Fuel = fuel
                };

                for (int j = 0; j < track.Length; j++)
                {
                    double currentZoneFuel = track[j];
                    bool isCheckPoint = checkPoints.Contains(j);

                    if (isCheckPoint)
                    {
                        driver.Fuel += currentZoneFuel;
                    }
                    else
                    {
                        driver.Fuel -= currentZoneFuel;

                        if (driver.Fuel <= 0)
                        {
                            driver.ZoneReached = j;
                            break;
                        }
                    }
                }

                drivers.Add(driver);
            }

            foreach (var driver in drivers)
            {
                Console.WriteLine(driver.Fuel > 0 ?
                    $"{driver.Name} - fuel left {driver.Fuel:f2}" : $"{driver.Name} - reached {driver.ZoneReached}");
            }
        }
    }
}
