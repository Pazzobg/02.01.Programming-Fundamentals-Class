namespace _03.FoldAndSum
{
    using System;

    public class FoldAndSum
    {
        public static void Main()
        {
            string[] line = Console.ReadLine().Split(' ');
            int[] numbers = new int[line.Length];
            for (int i = 0; i < line.Length; i++)
            {
                numbers[i] = int.Parse(line[i]);
            }

            int k = numbers.Length / 4;

            int[] tempArr = new int[k];
            for (int i = 0; i < k; i++)
            {
                tempArr[i] = numbers[i];
            }

            int[] upLeftArr = new int[k];
            for (int i = 0; i < k; i++)
            {
                upLeftArr[i] = tempArr[tempArr.Length - 1 - i];
            }

            int[] upRightArr = new int[k];
            for (int i = 0; i < k; i++)
            {
                upRightArr[i] = numbers[numbers.Length - 1 - i];
            }

            int[] bottomArr = new int[2 * k];
            for (int i = 0; i < bottomArr.Length; i++)
            {
                bottomArr[i] = numbers[k + i];
            }

            int[] topArr = new int[bottomArr.Length];
            for (int i = 0; i < k; i++)
            {
                topArr[i] = upLeftArr[i];
                topArr[i + k] = upRightArr[i];
            }

            int[] sum = new int[bottomArr.Length];
            for (int i = 0; i < bottomArr.Length; i++)
            {
                sum[i] = topArr[i] + bottomArr[i];
            }

            Console.WriteLine(string.Join(" ", sum));
        }
    }
}
