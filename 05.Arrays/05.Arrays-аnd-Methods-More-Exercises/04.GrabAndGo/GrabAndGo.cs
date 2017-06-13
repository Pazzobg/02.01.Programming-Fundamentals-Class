namespace _04.GrabAndGo
{
    using System;

    public class GrabAndGo
    {
        public static void Main()
        {
            string[] line = Console.ReadLine().Split(' ');
            int[] numbersArr = new int[line.Length];
            for (int i = 0; i < line.Length; i++)
            {
                numbersArr[i] = int.Parse(line[i]);
            }

            int wantedNumber = int.Parse(Console.ReadLine());

            int lastPositionOfWantedNum = -1;

            lastPositionOfWantedNum = Array.LastIndexOf(numbersArr, wantedNumber);

            if (lastPositionOfWantedNum == -1)
            {
                Console.WriteLine("No occurrences were found!");
            }
            else
            {
                long sum = 0;

                for (int i = 0; i < lastPositionOfWantedNum; i++)
                {
                    sum += numbersArr[i];
                }

                Console.WriteLine(sum);
            }
        }
    }
}