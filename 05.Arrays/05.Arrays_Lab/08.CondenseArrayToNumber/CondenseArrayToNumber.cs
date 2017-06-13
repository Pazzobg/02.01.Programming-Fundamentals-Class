namespace _08.CondenseArrayToNumber
{
    using System;
    using System.Linq;

    public class CondenseArrayToNumber
    {
        public static void Main()
        {
            int[] numbers = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();

            if (numbers.Length == 1)
            {
                Console.WriteLine($"{numbers[0]} is already condensed to number");
            }
            else
            {
                while (numbers.Length > 1)
                {
                    int[] condensedArr = new int[numbers.Length - 1];

                    for (int i = 0; i < numbers.Length - 1; i++)
                    {
                        condensedArr[i] = numbers[i] + numbers[i + 1];
                    }

                    numbers = condensedArr;
                }

                Console.WriteLine(numbers[0]);
            }
        }
    }
}
