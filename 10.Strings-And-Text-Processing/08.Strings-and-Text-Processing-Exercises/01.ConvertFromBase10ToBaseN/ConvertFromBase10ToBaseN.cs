namespace _01.ConvertFromBase10ToBaseN
{
    using System;
    using System.Collections.Generic;
    using System.Numerics;

    public class ConvertFromBase10ToBaseN
    {
        public static void Main()
        {
            var numbers = Console.ReadLine().Split(' ');

            int baseNum = int.Parse(numbers[0]);
            BigInteger number = BigInteger.Parse(numbers[1]);

            var result = new List<int>();

            while (number > 0)
            {
                result.Insert(0, (int)(number % baseNum));

                number /= baseNum;
            }

            Console.WriteLine(string.Join(string.Empty, result));
        }
    }
}
