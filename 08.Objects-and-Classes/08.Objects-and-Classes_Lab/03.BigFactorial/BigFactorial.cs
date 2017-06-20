namespace _03.BigFactorial
{
    using System;
    using System.Numerics;

    public class BigFactorial
    {
        public static void Main()
        {
            int n = int.Parse(Console.ReadLine());
            BigInteger result = 1;

            for (int i = n; i > 1; i--)
            {
                result *= i;
            }
            Console.WriteLine(result);
        }
    }
}
