namespace _08.MostFrequentNumber
{
    using System;

    public class MostFrequentNumber
    {
        public static void Main()
        {
            string[] line = Console.ReadLine().Split(' ');
            int[] numbers = new int[line.Length];
            for (int i = 0; i < line.Length; i++)
            {
                numbers[i] = int.Parse(line[i]);
            }

            int maxFrequencyCount = 0;
            int mostFrequentNumber = 0;

            for (int i = 0; i < numbers.Length; i++)
            {
                int currentFrequencyCount = 0;

                for (int j = 0; j < numbers.Length; j++)
                {
                    if (numbers[i] == numbers[j])
                    {
                        currentFrequencyCount++;
                    }
                }

                if (currentFrequencyCount > maxFrequencyCount)
                {
                    maxFrequencyCount = currentFrequencyCount;
                    mostFrequentNumber = numbers[i];
                }
            }

            Console.WriteLine(mostFrequentNumber);
        }
    }
}
