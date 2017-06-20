namespace _07.SalesReport
{
    using System;
    using System.Collections.Generic;

    public class SalesReport
    {
        public static void Main()
        {
            var sales = new SortedDictionary<string, decimal>();

            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                string[] input = Console.ReadLine().Split(' ');

                var currentSale = new Sale
                {
                    Town = input[0],
                    Product = input[1],
                    Price = decimal.Parse(input[2]),
                    Quantity = decimal.Parse(input[3])
                };

                if (!sales.ContainsKey(currentSale.Town))
                {
                    sales[currentSale.Town] = 0;
                }

                sales[currentSale.Town] += currentSale.Price * currentSale.Quantity;
            }

            foreach (var town in sales)
            {
                Console.WriteLine($"{town.Key} -> {town.Value:f2}");
            }
        }
    }
}
