namespace _15.FastPrimeCheckerRefactor
{
    using System;

    public class FastPrimeCheckerRefactor
    {
        public static void Main()
        {
            int number = int.Parse(Console.ReadLine());
            for (int i = 2; i <= number; i++)
            {
                bool prime = true;

                for (int j = 2; j <= Math.Sqrt(i); j++)
                {
                    if (i % j == 0)
                    {
                        prime = false;
                        break;
                    }
                }
                Console.WriteLine($"{i} -> {prime}");
            }
        }
    }
}
