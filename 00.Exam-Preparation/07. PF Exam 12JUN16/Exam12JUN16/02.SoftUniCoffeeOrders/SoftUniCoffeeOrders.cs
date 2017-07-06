namespace _02.SoftUniCoffeeOrders
{
    using System;
    using System.Collections.Generic;
    using System.Globalization;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    public class SoftUniCoffeeOrders
    {
        public static void Main()
        {
            int n = int.Parse(Console.ReadLine());
            decimal totalPrice = 0;

            for (int i = 0; i < n; i++)
            {
                decimal pricePerCapsule = decimal.Parse(Console.ReadLine());
                var orderDate = DateTime.ParseExact(Console.ReadLine(), "d/M/yyyy", CultureInfo.InvariantCulture);
                long capsulesCount = long.Parse(Console.ReadLine());

                int daysInMonth = DateTime.DaysInMonth(orderDate.Year, orderDate.Month);

                decimal currentPrice = (daysInMonth * capsulesCount) * pricePerCapsule;

                Console.WriteLine($"The price for the coffee is: ${currentPrice:f2}");
                totalPrice += currentPrice;
            }

            Console.WriteLine($"Total: ${totalPrice:f2}");
        }
    }
}
