namespace _04.LargestThreeNumbers
{
    using System;
    using System.Linq;

    public class LargestThreeNumbers
    {
        public static void Main()
        {
            var numbers = Console.ReadLine().Split(' ').Select(double.Parse).ToList();

            var result = numbers
                .OrderByDescending(x => x)
                .Take(3);

            Console.WriteLine(string.Join(" ", result));
        }
    }
}