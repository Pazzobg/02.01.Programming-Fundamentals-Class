namespace _10.Debugging_PriceChangeAlert
{
    using System;

    public class PriceChangeAlert
    {
        public static void Main()
        {
            int n = int.Parse(Console.ReadLine());
            double significanceLimit = double.Parse(Console.ReadLine());
            double lastPrice = double.Parse(Console.ReadLine());

            for (int i = 0; i < n - 1; i++)
            {
                double currentPrice = double.Parse(Console.ReadLine());
                double deviation = CalculateDeviation(lastPrice, currentPrice);
                bool isSignificantDifference = FindIfMajorSignifficance(deviation, significanceLimit);

                string message = CalculateAndPrintDifference(currentPrice, lastPrice, deviation, isSignificantDifference);
                Console.WriteLine(message);

                lastPrice = currentPrice;
            }
        }

        public static string CalculateAndPrintDifference(double currentPrice, double lastPrice, double deviation, bool isSignificantDifference)
        {
            string output = string.Empty;
            if (deviation == 0)
            {
                output = $"NO CHANGE: {currentPrice}";
            }
            else if (!isSignificantDifference)
            {
                output = $"MINOR CHANGE: {lastPrice} to {currentPrice} ({(deviation * 100):F2}%)";
            }
            else if (isSignificantDifference && (deviation > 0))
            {
                output = $"PRICE UP: {lastPrice} to {currentPrice} ({(deviation * 100):F2}%)";
            }
            else if (isSignificantDifference && (deviation < 0))
            {
                output = $"PRICE DOWN: {lastPrice} to {currentPrice} ({(deviation * 100):F2}%)";
            }

            return output;
        }

        public static bool FindIfMajorSignifficance(double deviation, double significanceLimit)
        {
            if (Math.Abs(deviation) >= significanceLimit)
            {
                return true;
            }

            return false;
        }

        public static double CalculateDeviation(double lastPrice, double currentPrice)
        {
            double difference = (currentPrice - lastPrice) / lastPrice;
            return difference;
        }
    }
}
