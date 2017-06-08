namespace _06.MaxSequenceOfEqualElements
{
    using System;

    public class MaxSequenceOfEqualElements
    {
        public static void Main()
        {
            string[] line = Console.ReadLine().Split(' ');
            int[] numbers = new int[line.Length];
            for (int i = 0; i < line.Length; i++)
            {
                numbers[i] = int.Parse(line[i]);
            }

            int countCurrentSequence = 1;
            int longestSequence = 1;
            int valueLongestSequence = 0;

            for (int i = 0; i < numbers.Length - 1; i++)
            {
                if (numbers[i + 1] == numbers[i])
                {
                    countCurrentSequence++;

                    if (countCurrentSequence > longestSequence)
                    {
                        longestSequence = countCurrentSequence;
                        valueLongestSequence = numbers[i];
                    }
                }

                if (numbers[i + 1] != numbers[i])
                {
                    countCurrentSequence = 1;
                }
            }

            for (int i = 0; i < longestSequence; i++)
            {
                Console.Write($"{valueLongestSequence} ");
            }

            Console.WriteLine();
        }
    }
}
