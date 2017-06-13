namespace _01.ArrayStatistics
{
    using System;

    public class ArrayStatistics
    {
        public static void Main()
        {
            string[] line = Console.ReadLine().Split(' ');
            int[] numbers = new int[line.Length];
            for (int i = 0; i < line.Length; i++)
            {
                numbers[i] = int.Parse(line[i]);
            }

            int minValue = GetMinValue(numbers);
            int maxValue = GetMaxValue(numbers);
            int sum = GetSumOfAllValues(numbers);
            double average = GetAverageOfAllValues(numbers, sum);

            Console.WriteLine($"Min = {minValue}\nMax = {maxValue}\nSum = {sum}\nAverage = {average}");
        }

        public static int GetMinValue(int[] numbers)
        {
            int minValue = int.MaxValue;

            for (int i = 0; i < numbers.Length; i++)
            {
                if (numbers[i] < minValue)
                {
                    minValue = numbers[i];
                }
            }

            return minValue;
        }

        public static int GetMaxValue(int[] numbers)
        {
            int maxValue = int.MinValue;

            for (int i = 0; i < numbers.Length; i++)
            {
                if (numbers[i] > maxValue)
                {
                    maxValue = numbers[i];
                }
            }

            return maxValue;
        }

        public static int GetSumOfAllValues(int[] numbers)
        {
            int sum = 0;

            for (int i = 0; i < numbers.Length; i++)
            {
                sum += numbers[i];
            }

            return sum;
        }

        public static double GetAverageOfAllValues(int[] numbers, int sum)
        {
            return (double)sum / numbers.Length;
        }
    }
}
