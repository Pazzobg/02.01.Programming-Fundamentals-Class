using System;

public class Program
{
    public static void Main()
    {
        string profession = Console.ReadLine().ToLower();
        string drink = string.Empty;

        switch (profession)
        {
            case "athlete": drink = "Water"; break;
            case "businessman":
            case "businesswoman": drink = "Coffee"; break;
            case "softuni student": drink = "Beer"; break;
            default: drink = "Tea"; break;
        }

        Console.WriteLine(drink);
    }
}

