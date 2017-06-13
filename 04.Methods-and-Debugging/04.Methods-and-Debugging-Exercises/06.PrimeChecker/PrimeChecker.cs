namespace _06.PrimeChecker
{
    using System;

    public class PrimeChecker
    {
        public static void Main()
        {
            long number = long.Parse(Console.ReadLine());

            bool isPrime = CheckIfPrime(number);

            Console.WriteLine(isPrime);
        }

        public static bool CheckIfPrime(long number)
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
