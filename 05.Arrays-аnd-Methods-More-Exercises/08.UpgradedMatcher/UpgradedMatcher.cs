namespace _08.UpgradedMatcher
{
    using System;
    using System.Linq;

    public class UpgradedMatcher
    {
        public static void Main()
        {
            string[] products = Console.ReadLine().Split(' ');
            long[] quantities = Console.ReadLine().Split(' ').Select(long.Parse).ToArray();
            decimal[] prices = Console.ReadLine().Split(' ').Select(decimal.Parse).ToArray();

            string[] input = Console.ReadLine().Split(' ');

            while (input[0] != "done")
            {
                string currentProduct = input[0];
                long orderQuantity = long.Parse(input[1]);

                int index = Array.IndexOf(products, currentProduct);

                bool found = true;
                bool enough = true;

                if (index > quantities.Length - 1)
                {
                    found = false;
                }
                else if (orderQuantity > quantities[index])
                {
                    enough = false;
                }

                if (found && enough)
                {
                    Console.WriteLine($"{products[index]} x {orderQuantity} costs {(orderQuantity * prices[index]):f2}");
                    quantities[index] -= orderQuantity;
                }
                else
                {
                    Console.WriteLine($"We do not have enough {products[index]}");
                }

                input = Console.ReadLine().Split(' ');
            }
        }
    }
}
