namespace _01.WormTest
{
    using System;

    public class WormTest
    {
        public static void Main()
        {
            int lenghtCm = int.Parse(Console.ReadLine()) * 100;
            double width = double.Parse(Console.ReadLine());

            double remainder = lenghtCm % width;

            if (remainder > 0)
            {
                double percentage = (lenghtCm / width) * 100;
                Console.WriteLine($"{percentage:f2}%");
            }
            else
            {
                double product = lenghtCm * width;
                Console.WriteLine($"{product:f2}");
            }
        }
    }
}
