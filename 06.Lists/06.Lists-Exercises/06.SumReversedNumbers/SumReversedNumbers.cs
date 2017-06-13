namespace _06.SumReversedNumbers
{
    using System;
    using System.Linq;

    public class SumReversedNumbers
    {
        public static void Main()
        {
            string[] numbers = Console.ReadLine().Split(' ');
            long sum = 0;

            for (int i = 0; i < numbers.Length; i++)
            {
                int reversedParsedNum = int.Parse(string.Join(string.Empty, numbers[i].Reverse()));
                sum += reversedParsedNum;
            }

            Console.WriteLine(sum);
        }
    }
}
