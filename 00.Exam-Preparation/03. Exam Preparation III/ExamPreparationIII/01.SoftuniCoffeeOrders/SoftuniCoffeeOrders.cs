namespace _01.SoftuniCoffeeOrders
{
    using System;
    using System.Globalization;

    public class SoftuniCoffeeOrders
    {
        public static void Main()
        {
            int n = int.Parse(Console.ReadLine());
            decimal totalPrice = 0;

            for (int i = 0; i < n; i++)
            {
                decimal pricePerCapsule = decimal.Parse(Console.ReadLine());
                DateTime orderDate = DateTime.ParseExact(Console.ReadLine(), "d/M/yyyy", CultureInfo.InvariantCulture);
                int capsulesCount = int.Parse(Console.ReadLine());

                decimal currentPrice = DateTime.DaysInMonth(orderDate.Year, orderDate.Month) * pricePerCapsule * capsulesCount;

                Console.WriteLine($"The price for the coffee is: ${currentPrice:f2}");
                totalPrice += currentPrice;
            }

            Console.WriteLine($"Total: ${totalPrice:f2}");
        }
    }
}
