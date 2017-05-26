using System;

public class Program
{
    public static void Main()
    {
        string profession = Console.ReadLine();
        int quantity = int.Parse(Console.ReadLine());
        double price = 0;

        switch (profession)
        {
            case "Athlete": price = 0.70; break;
            case "Businessman":
            case "Businesswoman": price = 1; break;
            case "SoftUni Student": price = 1.70; break;
            default: price = 1.2; break;
        }

        Console.WriteLine("The {0} has to pay {1:f2}.", profession, quantity * price);
    }
}