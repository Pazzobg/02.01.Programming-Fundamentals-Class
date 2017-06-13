namespace _07.PrimesInGivenRange
{
    using System;
    using System.Collections.Generic;

    public class PrimesInGivenRange
    {
        public static void Main()
        {
            int startNum = int.Parse(Console.ReadLine());
            int endNum = int.Parse(Console.ReadLine());

            List<int> primesList = FindAllPrimesInRange(startNum, endNum);

            Console.WriteLine(string.Join(", ", primesList));
        }

        public static List<int> FindAllPrimesInRange(int startNum, int endNum)
        {
            var primes = new List<int>();
            bool currentPrime = false;

            for (int i = startNum; i <= endNum; i++)
            {
                currentPrime = CheckCurrentNumberIfPrime(i);

                if (currentPrime)
                {
                    primes.Add(i);
                }
            }

            return primes;
        }

        public static bool CheckCurrentNumberIfPrime(int number)
        {
            bool prime = true;
            long divider = 2;
            double squareRootOfNum = Math.Sqrt(number);
            long result = 0;

            if (number < 2)
            {
                prime = false;
            }
            else
            {
                while (prime && divider <= squareRootOfNum)
                {
                    result = number % divider;

                    if (result == 0)
                    {
                        prime = false;
                    }

                    divider++;
                }
            }

            return prime;
        }
    }
}
