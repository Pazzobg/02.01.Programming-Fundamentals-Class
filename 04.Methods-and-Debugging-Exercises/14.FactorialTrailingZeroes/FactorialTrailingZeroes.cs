namespace _14.FactorialTrailingZeroes
{
    using System;
    using System.Numerics;

    public class FactorialTrailingZeroes
    {
        public static void Main()
        {
            short n = short.Parse(Console.ReadLine());
            BigInteger factorial = CalculateFactorial(n);

            int zeroesCount = CountTrailingZeroes(factorial);

            Console.WriteLine(zeroesCount);
        }

        public static BigInteger CalculateFactorial(short n)
        {
            BigInteger factorial = 1;

            for (int i = 1; i <= n; i++)
            {
                factorial *= i;
            }

            return factorial;
        }

        public static int CountTrailingZeroes(BigInteger factorial)
        {
            int counter = 0;

            while (factorial % 10 == 0)
            {
                counter++;
                factorial /= 10;
            }

            return counter;
        }
    }
}