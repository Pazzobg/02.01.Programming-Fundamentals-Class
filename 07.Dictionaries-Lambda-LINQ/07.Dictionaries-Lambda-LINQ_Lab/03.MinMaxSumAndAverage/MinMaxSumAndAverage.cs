namespace _03.MinMaxSumAndAverage
{
    using System;
    using System.Linq;

    public class MinMaxSumAndAverage
    {
        public static void Main()
        {
            int n = int.Parse(Console.ReadLine());

            int[] numbers = new int[n];

            for (int i = 0; i < n; i++)
            {
                numbers[i] = int.Parse(Console.ReadLine());
            }

            Console.WriteLine(
                $"Sum = {numbers.Sum()}\nMin = {numbers.Min()}\nMax = {numbers.Max()}\nAverage = {numbers.Average()}");
        }
    }
}
