namespace _01.SweetDessert
{
    using System;

    public class SweetDessert
    {
        public static void Main()
        {
            decimal budget = decimal.Parse(Console.ReadLine());
            int numberOfGuests = int.Parse(Console.ReadLine());
            decimal priceBananaPerPiece = decimal.Parse(Console.ReadLine());
            decimal priceEggsPerPiece = decimal.Parse(Console.ReadLine());
            decimal priceBerriesPerPiece = decimal.Parse(Console.ReadLine());

            int countOfSetsToPrepare = numberOfGuests / 6;
            if (numberOfGuests % 6 != 0)
            {
                countOfSetsToPrepare++;
            }

            int totalBananas = countOfSetsToPrepare * 2;
            int totalEggs = countOfSetsToPrepare * 4;
            decimal totalBerries = countOfSetsToPrepare * 0.2m;

            decimal totalCosts =
                (totalBananas * priceBananaPerPiece)
                + (totalEggs * priceEggsPerPiece)
                + (totalBerries * priceBerriesPerPiece);

            var difference = totalCosts - budget;

            if (difference <= 0)
            {
                Console.WriteLine($"Ivancho has enough money - it would cost {totalCosts:f2}lv.");
            }
            else
            {
                Console.WriteLine($"Ivancho will have to withdraw money - he will need {difference:f2}lv more.");
            }
        }
    }
}
