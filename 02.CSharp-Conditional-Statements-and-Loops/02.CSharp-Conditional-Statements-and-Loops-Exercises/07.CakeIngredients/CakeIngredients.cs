using System;

public class CakeIngredients
{
    public static void Main()               
    {
        int counter = 0;
        string input = Console.ReadLine();

        while (input != "Bake!")
        {
            Console.WriteLine($"Adding ingredient {input}.");
            counter++;

            input = Console.ReadLine();
        }

        Console.WriteLine($"Preparing cake with {counter} ingredients.");
    }
}