namespace _05.WeatherForecast
{
    using System;

    public class WeatherForecast
    {
        public static void Main()
        {
            string input = Console.ReadLine();
            try
            {
                long number = long.Parse(input);

                if (number >= sbyte.MinValue && number <= sbyte.MaxValue)
                {
                    Console.WriteLine("Sunny");
                }
                else if (number >= int.MinValue && number <= int.MaxValue)
                {
                    Console.WriteLine("Cloudy");
                }
                else
                {
                    Console.WriteLine("Windy");
                }
            }
            catch
            {
                Console.WriteLine("Rainy");
            }
        }
    }
}
