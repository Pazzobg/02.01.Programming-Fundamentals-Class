namespace _07.AndreyAndBilliard
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class AndreyAndBilliard
    {
        public static void Main()
        {
            var productsAtTheBar = new Dictionary<string, decimal>();

            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                string[] input = Console.ReadLine().Split('-');
                string productName = input[0];
                decimal price = decimal.Parse(input[1]);

                if (!productsAtTheBar.ContainsKey(productName))
                {
                    productsAtTheBar[productName] = 0;
                }

                productsAtTheBar[productName] = price;
            }

            var customersSummary = new List<Customer>();

            string[] nextCustomer = Console.ReadLine().Split('-', ',');     // need new char[] ?????

            while (nextCustomer[0] != "end of clients")
            {
                string customerName = nextCustomer[0];
                string productName = nextCustomer[1];
                int orderedQuantity = int.Parse(nextCustomer[2]);

                if (!productsAtTheBar.ContainsKey(productName))
                {
                    nextCustomer = Console.ReadLine().Split('-', ',');
                    continue;
                }

                decimal currentProductPrice = productsAtTheBar[productName];

                Customer currentCustomer = new Customer
                {
                    Name = customerName,
                    OrdersList = new Dictionary<string, int>(),
                    Bill = 0
                };

                if (!currentCustomer.OrdersList.ContainsKey(productName))
                {
                    currentCustomer.OrdersList[productName] = 0;
                }

                currentCustomer.OrdersList[productName] += orderedQuantity;

                currentCustomer.Bill += orderedQuantity * currentProductPrice;

                if (customersSummary.Any(c => c.Name == currentCustomer.Name))
                {
                    Customer existingCustomer = customersSummary.First(c => c.Name == currentCustomer.Name);

                    if (!existingCustomer.OrdersList.ContainsKey(productName))
                    {
                        existingCustomer.OrdersList[productName] = 0;
                    }

                    existingCustomer.OrdersList[productName] += orderedQuantity;
                    existingCustomer.Bill += currentCustomer.Bill;
                }
                else
                {
                    customersSummary.Add(currentCustomer);
                }

                nextCustomer = Console.ReadLine().Split('-', ',');
            }

            decimal totalBill = 0;

            foreach (var customer in customersSummary.OrderBy(x => x.Name))
            {
                Console.WriteLine(customer.Name);

                foreach (var kvp in customer.OrdersList)
                {
                    Console.WriteLine($"-- {kvp.Key} - {kvp.Value}");
                }

                Console.WriteLine($"Bill: {customer.Bill:f2}");

                totalBill += customer.Bill;
            }

            Console.WriteLine($"Total bill: {totalBill:f2}");
        }
    }
}
