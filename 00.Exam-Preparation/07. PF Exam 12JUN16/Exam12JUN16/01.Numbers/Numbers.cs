namespace _01.Numbers
{
    using System;
    using System.Linq;

    public class Numbers
    {
        public static void Main()
        {
            int[] numbers = Console.ReadLine()
                .Split(new[] { ' ', '\t' }, StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();

            var output = numbers
                .Where(x => x > numbers.Average())
                .OrderByDescending(x => x)
                .Take(5)
                .ToArray();

            Console.WriteLine(output.Length > 0 ? string.Join(" ", output) : "No");
        }
    }
}
