namespace _02.VaporStore
{
    using System;
    using System.Collections.Generic;

    public class VaporStore
    {
        public static void Main()
        {
            double budget = double.Parse(Console.ReadLine());
            double money = budget;

            double outfallPrice = 39.99;
            double csPrice = 15.99;
            double zplinterZellPrice = 19.99;
            double honoredPrice = 59.99;
            double roverWatchPrice = 29.99;
            double roverOriginsPrice = 39.99;

            bool broke = false;

            string input = Console.ReadLine();

            while (input != "Game Time")
            {
                if (input == "OutFall 4")
                {
                    if (money >= outfallPrice)
                    {
                        money -= outfallPrice;
                        Console.WriteLine($"Bought {input}");
                    }
                    else Console.WriteLine("Too Expensive");
                }
                else if (input == "CS: OG")
                {
                    if (money >= csPrice)
                    {
                        money -= csPrice;
                        Console.WriteLine($"Bought {input}");
                    }
                    else Console.WriteLine("Too Expensive");
                }
                else if (input == "Zplinter Zell")
                {
                    if (money >= zplinterZellPrice)
                    {
                        Console.WriteLine($"Bought {input}");
                        money -= zplinterZellPrice;
                    }
                    else Console.WriteLine("Too Expensive");
                }
                else if (input == "Honored 2")
                {
                    if (money >= honoredPrice)
                    {
                        Console.WriteLine($"Bought {input}");
                        money -= honoredPrice;
                    }
                    else Console.WriteLine("Too Expensive");
                }
                else if (input == "RoverWatch")
                {
                    if (money >= roverWatchPrice)
                    {
                        Console.WriteLine($"Bought {input}");
                        money -= roverWatchPrice;
                    }
                    else Console.WriteLine("Too Expensive");
                }
                else if (input == "RoverWatch Origins Edition")
                {
                    if (money >= roverOriginsPrice)
                    {
                        Console.WriteLine($"Bought {input}");
                        money -= roverOriginsPrice;
                    }
                    else Console.WriteLine("Too Expensive");
                }
                else
                {
                    Console.WriteLine("Not Found");
                }

                if (money == 0)
                {
                    Console.WriteLine("Out of money!");
                    broke = true;
                    break;
                }

                input = Console.ReadLine();
            }
            if (!broke)
            {
                Console.WriteLine($"Total spent: ${(budget - money):f2}. Remaining: ${money:f2}");
            }
        }
    }
}
