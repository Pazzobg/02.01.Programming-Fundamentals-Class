namespace _04.SupermarketDatabase
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class SupermarketDatabase
    {
        public static void Main()
        {
            var productsQuantitiesPrices = new Dictionary<string, Dictionary<string, decimal>>();

            string[] input = Console.ReadLine().Split(' ');

            while (input[0] != "stocked")
            {
                string product = input[0];
                decimal price = decimal.Parse(input[1]);
                decimal quantity = decimal.Parse(input[2]);

                if (!productsQuantitiesPrices.ContainsKey(product))
                {
                    productsQuantitiesPrices[product] = new Dictionary<string, decimal>();
                    productsQuantitiesPrices[product]["Price"] = 0;
                    productsQuantitiesPrices[product]["Quantity"] = 0;
                }

                productsQuantitiesPrices[product]["Price"] = price;
                productsQuantitiesPrices[product]["Quantity"] += quantity;

                input = Console.ReadLine().Split(' ');
            }

            decimal grandTotal = 0;

            foreach (var outerKvp in productsQuantitiesPrices)
            {
                string productName = outerKvp.Key;
                var priceQuantity = outerKvp.Value;
                decimal currentPrice = priceQuantity["Price"];
                decimal currentQuantity = priceQuantity["Quantity"];
                decimal totalPrice = currentPrice * currentQuantity;
                grandTotal += totalPrice;

                Console.WriteLine($"{productName}: ${currentPrice:f2} * {currentQuantity} = ${totalPrice:f2}");
            }

            Console.WriteLine(new string('-', 30));
            Console.WriteLine($"Grand Total: ${grandTotal:f2}");
        }
    }
}
