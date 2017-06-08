namespace _05.RoundingNumbersAwayFromZero
{
    using System;

    public class RoundingNumbersAwayFromZero
    {
        public static void Main()
        {
            string[] line = Console.ReadLine().Split(' ');
            double[] numbersArr = new double[line.Length];

            for (int i = 0; i < line.Length; i++)
            {
                numbersArr[i] = double.Parse(line[i]);
            }

            for (int i = 0; i < numbersArr.Length; i++)
            {
                int roundedValue = (int)Math.Round(numbersArr[i], MidpointRounding.AwayFromZero);

                Console.WriteLine($"{numbersArr[i]} => {roundedValue}");
            }
        }
    }
}
