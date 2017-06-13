namespace _07.SumArrays
{
    using System;
    using System.Linq;

    public class SumArrays
    {
        public static void Main()
        {
            int[] numsArrFirst = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            int[] numsArrSecond = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();

            int longerArrayLength = Math.Max(numsArrFirst.Length, numsArrSecond.Length);

            int[] numsSum = new int[longerArrayLength];

            for (int i = 0; i < longerArrayLength; i++)
            {
                numsSum[i] = numsArrFirst[i % numsArrFirst.Length] + numsArrSecond[i % numsArrSecond.Length];
            }

            Console.WriteLine(string.Join(" ", numsSum));
        }
    }
}
