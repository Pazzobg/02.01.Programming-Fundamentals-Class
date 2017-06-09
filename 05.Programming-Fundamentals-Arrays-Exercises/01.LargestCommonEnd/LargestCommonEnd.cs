namespace _01.LargestCommonEnd
{
    using System;

    public class LargestCommonEnd
    {
        public static void Main()
        {
            string[] firstArr = Console.ReadLine().Split(' ');
            string[] secondArr = Console.ReadLine().Split(' ');

            int shorterLength = Math.Min(firstArr.Length, secondArr.Length);
            int counterLeft = 0;
            int counterRight = 0;

            for (int i = 0; i < shorterLength; i++)
            {
                if (firstArr[i] == secondArr[i])
                {
                    counterLeft++;
                }
                if (firstArr[firstArr.Length - 1 - i] == secondArr[secondArr.Length - 1 - i])
                {
                    counterRight++;
                }
            }

            int largestCommonEnd = Math.Max(counterLeft, counterRight);
            Console.WriteLine(largestCommonEnd);

            /* Alternative aft check: 
             *  for (int i = inputArrOne.Length - 1, j = inputArrTwo.Length - 1; i >= 0 && j >= 0; i--, j--)
                {
                    if (inputArrOne[i] == inputArrTwo[j])
                    {
                        counterAft++;
                    }
                    else
                    {
                        break;
                    }
                }
             */
        }
    }
}
