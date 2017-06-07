namespace _05.FibonacciNumbers
{
    using System;

    public class FibonacciNumbers
    {
        public static void Main()
        {
            int n = int.Parse(Console.ReadLine());

            FindNthFibonacciNumber(n);
        }

        public static void FindNthFibonacciNumber(int n)
        {
            if (n == 0 || n == 1)
            {
                Console.WriteLine("1");
            }
            else
            {
                int forelast = 1;
                int last = 1;
                int currentFibonacci = 0;

                for (int i = 1; i < n; i++)
                {
                    currentFibonacci = forelast + last;

                    last = forelast;
                    forelast = currentFibonacci;
                }

                Console.WriteLine(currentFibonacci);
            }
        }
    }
}
