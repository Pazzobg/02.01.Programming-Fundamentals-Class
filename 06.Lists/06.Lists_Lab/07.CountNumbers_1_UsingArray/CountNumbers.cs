namespace _07.CountNumbers_1_UsingArray
{
    using System;
    using System.Linq;

    public class CountNumbers
    {
        public static void Main()
        {
            var numbers = Console.ReadLine().Split(' ').Select(int.Parse).ToList();

            int largestNumber = numbers.Max();
            int[] counters = new int[largestNumber + 1];

            foreach (int number in numbers)
            {
                counters[number]++;
            }

            for (int i = 0; i < counters.Length; i++)
            {
                if (counters[i] != 0)
                {
                    Console.WriteLine($"{i} -> {counters[i]}");
                }
            }
        }
    }
}
