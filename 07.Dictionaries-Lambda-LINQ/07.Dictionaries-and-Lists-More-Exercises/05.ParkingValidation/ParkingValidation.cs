namespace _05.ParkingValidation
{
    using System;
    using System.Collections.Generic;

    public class ParkingValidation
    {
        public static void Main()
        {
            var usernameLicensePlate = new Dictionary<string, string>();

            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                string[] input = Console.ReadLine().Split(' ');

                string command = input[0];
                string username = input[1];

                switch (command)
                {
                    case "register":

                        string plate = input[2];

                        if (usernameLicensePlate.ContainsKey(username))
                        {
                            Console.WriteLine($"ERROR: already registered with plate number " +
                                $"{usernameLicensePlate[username]}");
                        }
                        else if (usernameLicensePlate.ContainsValue(plate))
                        {
                            Console.WriteLine($"ERROR: license plate {plate} is busy");
                        }
                        else
                        {
                            bool plateIsValid = CheckIfPlateIsValid(plate);

                            if (!plateIsValid)
                            {
                                Console.WriteLine($"ERROR: invalid license plate {plate}");
                                continue;
                            }
                            else
                            {
                                usernameLicensePlate[username] = plate;
                                Console.WriteLine($"{username} registered {plate} successfully");
                            }
                        }break;

                    case "unregister":

                        if (!usernameLicensePlate.ContainsKey(username))
                        {
                            Console.WriteLine($"ERROR: user {username} not found");
                        }
                        else
                        {
                            usernameLicensePlate.Remove(username);
                            Console.WriteLine($"user {username} unregistered successfully");
                        }
                        break;
                }
            }

            foreach (var kvp in usernameLicensePlate)
            {
                string name = kvp.Key;
                string plate = kvp.Value;

                Console.WriteLine($"{name} => {plate}");
            }
        }

        private static bool CheckIfPlateIsValid(string plate)
        {

            if (plate.Length != 8)
            {
                return false;
            }

            for (int j = 0; j < 2; j++)
            {
                if (plate[j] < 65 || plate[j] > 90)
                {
                    return false;
                }
            }

            for (int j = 2; j < 6; j++)
            {
                if (plate[j] < 48 || plate[j] > 57)
                {
                    return false;
                }
            }

            for (int j = 6; j < plate.Length; j++)
            {
                if (plate[j] < 65 || plate[j] > 90)
                {
                    return false;
                }
            }

            return true;
        }
    }
}