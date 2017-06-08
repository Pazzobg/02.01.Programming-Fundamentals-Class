namespace _03.LastKNumbersSums
{
    using System;

    public class LastKNumbersSums
    {
        public static void Main()
        {
            long n = long.Parse(Console.ReadLine());
            long k = long.Parse(Console.ReadLine());

            var numbersArr = new long[n];
            numbersArr[0] = 1;

            for (long i = 0; i < n; i++)
            {
                long start = Math.Max(0, i - k);
                long end = i - 1;
                long sum = 0;

                for (long j = start; j < n; j++)
                {
                    sum += numbersArr[j];
                }

                numbersArr[i] = sum;
            }

            Console.WriteLine(string.Join(" ", numbersArr));
        }
    }
}
