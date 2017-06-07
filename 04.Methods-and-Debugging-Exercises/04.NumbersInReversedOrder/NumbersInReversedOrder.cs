namespace _04.NumbersInReversedOrder
{
    using System;

    public class NumbersInReversedOrder
    {
        public static void Main()
        {
            string input = Console.ReadLine();

            ReverseCharsOrder(input);
        }

        public static void ReverseCharsOrder(string input)
        {
            string output = string.Empty;

            for (int i = input.Length - 1; i >= 0; i--)
            {
                output += input[i];
            }

            Console.WriteLine(output);
        }
    }
}
