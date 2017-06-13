namespace _06.FoldAndSumByLINQ
{
    using System;
    using System.Linq;

    public class FoldAndSumByLINQ
    {
        public static void Main()
        {
            int[] numbers = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            int k = numbers.Length / 4;

            var topLeft = numbers
                .Take(k)
                .Reverse();

            var topRight = numbers
                .Skip(3 * k)
                .Take(k)
                .Reverse();

            var bottomRow = numbers
                .Skip(k)
                .Take(2 * k);

            var topRow = topLeft.Concat(topRight);

            var result = topRow.Zip(bottomRow, (x, y) => x + y);

            Console.WriteLine(string.Join(" ", result));
        }
    }
}
