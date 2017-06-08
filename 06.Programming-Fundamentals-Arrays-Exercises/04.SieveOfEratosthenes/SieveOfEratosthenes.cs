namespace _04.SieveOfEratosthenes
{
    using System;

    public class SieveOfEratosthenes
    {
        public static void Main()
        {
            int n = int.Parse(Console.ReadLine());

            bool[] primes = new bool[n + 1];

            for (int i = 2; i < primes.Length; i++)
            {
                primes[i] = true;
            }

            for (int i = 2; i < primes.Length; i++)
            {
                if (primes[i] == true)
                {
                    Console.Write(i + " ");

                    for (int j = 2; (j * i) <= n; j++)
                    {
                        primes[i * j] = false;
                    }
                }
            }
        }
    }
}
