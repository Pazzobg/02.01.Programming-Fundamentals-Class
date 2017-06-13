namespace _08.MultiplyEvensByOdds
{
    using System;

    public class MultiplyEvensByOdds
    {
        public static void Main()
        {
            int n = Math.Abs(int.Parse(Console.ReadLine()));

            int result = GetMultipleOfEvensAndOdds(n);

            Console.WriteLine(result);
        }

        public static int GetMultipleOfEvensAndOdds(int n)
        {
            int sumOdds = GetSumOfOdds(n);
            int sumEvens = GetSumOfEvens(n);

            return sumEvens * sumOdds;
        }

        public static int GetSumOfOdds(int n)
        {
            int sumOdds = 0;

            while (n > 0)
            {
                int lastDigit = n % 10;

                if (lastDigit % 2 != 0) sumOdds += lastDigit;
                n /= 10;
            }

            return sumOdds;
        }

        public static int GetSumOfEvens(int n)
        {
            int sumEvens = 0;

            while (n > 0)
            {
                int lastDigit = n % 10;

                if (lastDigit % 2 == 0) sumEvens += lastDigit;
                n /= 10;
            }

            return sumEvens;
        }
    }
}
