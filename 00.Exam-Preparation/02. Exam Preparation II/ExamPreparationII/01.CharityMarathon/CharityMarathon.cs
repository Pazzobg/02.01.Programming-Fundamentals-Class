namespace _01.CharityMarathon
{
    using System;
    using System.Numerics;

    public class CharityMarathon
    {
        public static void Main()
        {
            int daysCount = int.Parse(Console.ReadLine());
            int participants = int.Parse(Console.ReadLine());
            int avgNumberOfLapsPerRunner = int.Parse(Console.ReadLine());
            int lapLengthMeters = int.Parse(Console.ReadLine());
            int capacity = int.Parse(Console.ReadLine());
            decimal moneyPerKm = decimal.Parse(Console.ReadLine());

            int actualRunnersCount = Math.Min(participants, capacity * daysCount);

            BigInteger totalKm = (actualRunnersCount * (BigInteger)avgNumberOfLapsPerRunner * lapLengthMeters) / 1000;

            decimal totalMoney = moneyPerKm * (decimal)totalKm;

            Console.WriteLine($"Money raised: {totalMoney:f2}");
        }
    }
}
