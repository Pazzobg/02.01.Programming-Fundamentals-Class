namespace _06.ReverseAnArrayOfStrings
{
    using System;
    using System.Linq;

    public class ReverseAnArrayOfStrings
    {
        public static void Main()
        {
            string[] input = Console.ReadLine().Split(' ');
            // Console.WriteLine(string.Join(" ", input.Reverse()));        Alternative Solution
            for (int i = 0; i < input.Length / 2; i++)
            {
                string temp = input[i];

                input[i] = input[input.Length - i - 1];
                input[input.Length - i - 1] = temp;
            }

            Console.WriteLine(string.Join(" ", input));
        }
    }
}
