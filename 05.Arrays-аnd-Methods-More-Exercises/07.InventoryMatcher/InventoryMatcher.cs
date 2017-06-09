namespace _07.InventoryMatcher
{
    using System;
    using System.Linq;

    public class InventoryMatcher
    {
        public static void Main()
        {
            string[] products = Console.ReadLine().Split(' ');
            long[] quantities = Console.ReadLine().Split(' ').Select(long.Parse).ToArray();
            decimal[] prices = Console.ReadLine().Split(' ').Select(decimal.Parse).ToArray();

            string input = Console.ReadLine();

            while (input != "done")
            {
                int index = Array.IndexOf(products, input);

                Console.WriteLine(
                    $"{products[index]} costs: {prices[index]}; Available quantity: {quantities[index]}");

                input = Console.ReadLine();
            }
        }
    }
}
