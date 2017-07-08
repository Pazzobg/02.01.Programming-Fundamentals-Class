namespace _03.WormHole
{
    using System;
    using System.Linq;

    public class WormHole
    {
        public static void Main()
        {
            int stepsCount = 0;
            int[] numbers = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();

            for (int i = 0; i < numbers.Length; i++)
            {
                stepsCount++;

                if (numbers[i] != 0)
                {
                    int temp = numbers[i];
                    numbers[i] = 0;
                    i = temp;
                }
            }

            Console.WriteLine(stepsCount);
        }
    }
}
