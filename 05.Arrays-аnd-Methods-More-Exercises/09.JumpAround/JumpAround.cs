namespace _09.JumpAround
{
    using System;

    public class JumpAround
    {
        public static void Main()
        {
            string[] line = Console.ReadLine().Split(' ');

            int[] numbersArr = new int[line.Length];
            for (int i = 0; i < line.Length; i++)
            {
                numbersArr[i] = int.Parse(line[i]);
            }

            int currentPositionIndex = 0;
            int currentValue = numbersArr[currentPositionIndex];
            int sum = currentValue;

            // while Jump Right is possible OR Jump Left is possible
            while ((currentPositionIndex + currentValue <= numbersArr.Length - 1) || (currentPositionIndex - currentValue >= 0))
            {
                if (currentPositionIndex + currentValue <= numbersArr.Length - 1)
                {
                    currentPositionIndex += currentValue;
                    currentValue = numbersArr[currentPositionIndex];
                    sum += currentValue;
                }
                else if (currentPositionIndex - currentValue >= 0)
                {
                    currentPositionIndex -= currentValue;
                    currentValue = numbersArr[currentPositionIndex];
                    sum += currentValue;
                }
            }

            Console.WriteLine(sum);
        }
    }
}
