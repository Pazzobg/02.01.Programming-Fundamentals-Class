namespace _02.ArrayModifier
{
    using System;
    using System.Linq;

    public class Arraymodifier
    {
        public static void Main()
        {
            long[] numbers = Console.ReadLine().Split(' ').Select(long.Parse).ToArray();

            string[] input = Console.ReadLine().Split(' ');

            while (input[0] != "end")
            {
                string command = input[0];

                switch (command)
                {
                    case "swap": SwapTwoElements(numbers, input[1], input[2]); break;
                    case "multiply": MultiplyTwoElements(numbers, input[1], input[2]); break;
                    case "decrease": DecreaseValuesOfAllElements(numbers); break;
                }

                input = Console.ReadLine().Split(' ');
            }

            Console.WriteLine(string.Join(", ", numbers));
        }

        public static void DecreaseValuesOfAllElements(long[] numbers)
        {
            for (int i = 0; i < numbers.Length; i++)
            {
                numbers[i]--;
            }
        }

        public static void MultiplyTwoElements(long[] numbers, string v1, string v2)
        {
            int index1 = int.Parse(v1);
            int index2 = int.Parse(v2);
            long result = numbers[index1] * numbers[index2];
            numbers[index1] = result;
        }

        public static void SwapTwoElements(long[] numbers, string v1, string v2)
        {
            int index1 = int.Parse(v1);
            int index2 = int.Parse(v2);
            long temp = numbers[index1];
            numbers[index1] = numbers[index2];
            numbers[index2] = temp;
        }
    }
}
