namespace _02.ConvertFromBaseNToBase10
{
    using System;
    using System.Numerics;

    public class ConvertFromBaseNToBase10
    {
        public static void Main()
        {
            string[] numbers = Console.ReadLine().Split(' ');

            int baseNum = int.Parse(numbers[0]);
            string number = numbers[1];
            BigInteger result = 0;

            for (int i = 0; i < number.Length; i++)
            {
                string digit = number[i].ToString();
                int currentNum = int.Parse(digit);

                result += currentNum * BigInteger.Pow(baseNum, number.Length - i - 1);
            }

            Console.WriteLine(result);
        }
    }
}
