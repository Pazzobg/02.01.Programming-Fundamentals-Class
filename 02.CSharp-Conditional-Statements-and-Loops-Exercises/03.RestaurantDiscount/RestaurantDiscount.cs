using System;

public class RestaurantDiscount
{
    public static void Main()
    {
        int customers = int.Parse(Console.ReadLine());
        string service = Console.ReadLine();
        int servicePackPrice = 0;
        string hallType = string.Empty;
        double hallPrice = 0;
        double discount = 0;

        switch (service)
        {
            case "Normal": servicePackPrice = 500; discount = 0.95; break;
            case "Gold": servicePackPrice = 750; discount = 0.90; break;
            case "Platinum": servicePackPrice = 1000; discount = 0.85; break;
        }

        if (customers <= 50)
        {
            hallPrice = 2500;
            hallType = "Small Hall";
        }
        else if (customers <= 100)
        {
            hallPrice = 5000;
            hallType = "Terrace";
        }
        else if (customers <= 120)
        {
            hallPrice = 7500;
            hallType = "Great Hall";
        }
        else
        {
            Console.WriteLine("We do not have an appropriate hall.");
            Environment.Exit(0);
        }

        double totalPriceInclDiscount = (hallPrice + servicePackPrice) * discount;
        double pricePerPerson = totalPriceInclDiscount / customers;

        Console.WriteLine($"We can offer you the {hallType}");
        Console.WriteLine($"The price per person is {pricePerPerson:f2}$");
    }
}