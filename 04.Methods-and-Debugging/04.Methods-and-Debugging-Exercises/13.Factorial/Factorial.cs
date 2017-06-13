namespace _13.Factorial
{
    using System;
    using System.Numerics;

    public class Factorial
    {
        public static void Main()
        {
            short n = short.Parse(Console.ReadLine());
            BigInteger factorial = CalculateFactorial(n);

            Console.WriteLine(factorial);
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
    }
}
