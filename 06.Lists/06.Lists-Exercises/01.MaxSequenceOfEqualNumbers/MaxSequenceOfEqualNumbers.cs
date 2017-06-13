namespace _01.MaxSequenceOfEqualNumbers
{
    using System;
    using System.Linq;

    public class MaxSequenceOfEqualNumbers
    {
        public static void Main()
        {
            var numbers = Console.ReadLine().Split(' ').Select(int.Parse).ToList();

            int longestSequenceMember = 0;
            int longestSequenceLenght = 1;

            int currentLenght = 1;

            for (int i = 0; i < numbers.Count - 1; i++)
            {
                if (numbers[i + 1] == numbers[i])
                {
                    currentLenght++;

                    if (currentLenght > longestSequenceLenght)
                    {
                        longestSequenceLenght = currentLenght;
                        longestSequenceMember = numbers[i];
                    }
                }
                else
                {
                    currentLenght = 1;
                }
            }

            if (longestSequenceLenght == 1)
            {
                longestSequenceMember = numbers[0];
            }

            for (int i = 0; i < longestSequenceLenght; i++)
            {
                Console.Write($"{longestSequenceMember} ");
            }

            Console.WriteLine();
        }
    }
}
