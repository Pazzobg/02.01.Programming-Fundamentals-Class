namespace _02.VehicleCatalogue
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class VehicleCatalogue
    {
        public static void Main()
        {
            var carsCatalogue = new List<Car>();
            var trucksCatalogue = new List<Truck>();

            string[] input = Console.ReadLine().Split(' ');

            while (input[0] != "End")
            {
                string type = input[0].ToLower();
                string model = input[1];
                string color = input[2];
                double hp = double.Parse(input[3]);

                if (type == "car")
                {
                    var currentCar = new Car
                    {
                        Type = type,
                        Model = model,
                        Color = color,
                        HorsePower = hp
                    };

                    carsCatalogue.Add(currentCar);
                }
                else if (type == "truck")
                {
                    var currentTruck = new Truck
                    {
                        Type = type,
                        Model = model,
                        Color = color,
                        HorsePower = hp
                    };

                    trucksCatalogue.Add(currentTruck);
                }

                input = Console.ReadLine().Split(' ');
            }

            string chosenVehicle = Console.ReadLine();

            while (chosenVehicle != "Close the Catalogue")
            {
                bool chosenIsCar = false;

                foreach (var car in carsCatalogue)
                {
                    if (car.Model == chosenVehicle)
                    {
                        chosenIsCar = true;
                        break;
                    }
                }

                if (chosenIsCar)
                {
                    var chosenOne = carsCatalogue.Where(x => x.Model == chosenVehicle).ToArray();
                    Console.WriteLine($"Type: Car");
                    Console.WriteLine($"Model: {chosenOne[0].Model}");
                    Console.WriteLine($"Color: {chosenOne[0].Color}");
                    Console.WriteLine($"Horsepower: {chosenOne[0].HorsePower}");
                }
                else
                {
                    var chosenOne = trucksCatalogue.Where(x => x.Model == chosenVehicle).ToArray();
                    Console.WriteLine($"Type: Truck");
                    Console.WriteLine($"Model: {chosenOne[0].Model}");
                    Console.WriteLine($"Color: {chosenOne[0].Color}");
                    Console.WriteLine($"Horsepower: {chosenOne[0].HorsePower}");
                }

                chosenVehicle = Console.ReadLine();
            }

            try
            {
                Console.WriteLine($"Cars have average horsepower of: {carsCatalogue.Average(x => x.HorsePower):f2}.");
            }
            catch (InvalidOperationException)
            {
                Console.WriteLine($"Cars have average horsepower of: 0.00.");
            }

            try
            {
                Console.WriteLine($"Trucks have average horsepower of: {trucksCatalogue.Average(x => x.HorsePower):f2}.");
            }
            catch (InvalidOperationException)
            {
                Console.WriteLine($"Trucks have average horsepower of: 0.00.");
            }
        }
    }
}
