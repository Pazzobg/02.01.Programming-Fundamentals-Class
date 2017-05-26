using System;

public class TrainingHallEquipment
{
    public static void Main()
    {
        double budget = double.Parse(Console.ReadLine());       
        double subTotal = 0;
        int n = int.Parse(Console.ReadLine());

        for (int i = 0; i < n; i++)
        {
            string item = Console.ReadLine();
            double price = double.Parse(Console.ReadLine());
            int count = int.Parse(Console.ReadLine());

            if (count > 1)
            {
                Console.WriteLine($"Adding {count} {item}s to cart.");
            }
            else
            {
                Console.WriteLine($"Adding {count} {item} to cart.");
            }

            subTotal += price * count;
        }

        double diff = budget - subTotal;

        Console.WriteLine($"Subtotal: ${subTotal:f2}");

        if (budget >= subTotal)
        {
            Console.WriteLine($"Money left: ${Math.Abs(diff):f2}");
        }
        else
        {
            Console.WriteLine($"Not enough. We need ${Math.Abs(diff):f2} more.");
        }
    }
}
