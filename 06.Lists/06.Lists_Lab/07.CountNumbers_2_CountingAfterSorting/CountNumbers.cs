namespace _07.CountNumbers_2_CountingAfterSorting
{
    using System;
    using System.Linq;

    public class CountNumbers
    {
        public static void Main()
        {
            var numbers = Console.ReadLine().Split(' ').Select(int.Parse).ToList();

            numbers.Sort();

            int counter = 1;

            int i = 0;
            for (; i < numbers.Count - 1; i++)
            {
                if (numbers[i] == numbers[i + 1])
                {
                    counter++;
                }
                else
                {
                    Console.WriteLine($"{numbers[i]} -> {counter}");
                    counter = 1;
                }
            }

            Console.WriteLine($"{numbers[i]} -> {counter}");
        }
    }
}
