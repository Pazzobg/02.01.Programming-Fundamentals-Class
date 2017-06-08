namespace _11.EqualSums
{
    using System;

    public class EqualSums
    {
        public static void Main()
        {
            string[] line = Console.ReadLine().Split(' ');
            int[] numbers = new int[line.Length];
            for (int i = 0; i < line.Length; i++)
            {
                numbers[i] = int.Parse(line[i]);
            }

            bool found = false;

            for (int i = 0; i < numbers.Length; i++)
            {
                int sumLeft = 0;

                for (int j = i - 1; j >= 0; j--)
                {
                    sumLeft += numbers[j];
                }

                int sumRight = 0;

                for (int k = i + 1; k < numbers.Length; k++)
                {
                    sumRight += numbers[k];
                }

                if (sumLeft == sumRight)
                {
                    found = true;
                    Console.WriteLine(i);
                }
            }

            if (!found)
            {
                Console.WriteLine("no");
            }
        }
    }
}
