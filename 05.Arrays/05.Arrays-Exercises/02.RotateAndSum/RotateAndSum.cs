namespace _02.RotateAndSum
{
    using System;

    public class RotateAndSum
    {
        public static void Main()
        {
            string[] line = Console.ReadLine().Split(' ');
            int[] numbersArr = new int[line.Length];
            for (int i = 0; i < line.Length; i++)
            {
                numbersArr[i] = int.Parse(line[i]);
            }

            int rotations = int.Parse(Console.ReadLine());

            int[] sumArr = new int[numbersArr.Length];

            for (int r = 1; r <= rotations; r++)
            {
                int lastValue = numbersArr[numbersArr.Length - 1];

                for (int i = numbersArr.Length - 1; i > 0; i--)
                {
                    numbersArr[i] = numbersArr[i - 1];
                }

                numbersArr[0] = lastValue;

                for (int i = 0; i < numbersArr.Length; i++)
                {
                    sumArr[i] += numbersArr[i];
                }
            }

            Console.WriteLine(string.Join(" ", sumArr));
        }
    }
}
