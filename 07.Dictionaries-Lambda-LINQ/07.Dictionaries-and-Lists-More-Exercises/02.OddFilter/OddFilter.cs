namespace _02.OddFilter
{
    using System;
    using System.Linq;

    public class OddFilter
    {
        public static void Main()
        {
            var numbers = Console.ReadLine().Split(' ').Select(int.Parse).ToList();
            numbers.RemoveAll(x => x % 2 != 0);

            var outputList = numbers.Select(x => x > numbers.Average() ? x += 1 : x -= 1);

            Console.WriteLine(string.Join(" ", outputList));
        }
    }
}
