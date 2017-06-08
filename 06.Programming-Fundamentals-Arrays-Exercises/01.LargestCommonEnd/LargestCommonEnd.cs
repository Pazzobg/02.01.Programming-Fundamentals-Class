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

            for (int checkFront = 0; checkFront < shorterLength; checkFront++)
            {
                if (firstArr[checkFront] == secondArr[checkFront])
                {
                    counterLeft++;
                }
                else break;
            }

            for (int checkAft = 0; checkAft < shorterLength; checkAft++)
            {
                if (firstArr[firstArr.Length - 1 - checkAft] == secondArr[secondArr.Length - 1 - checkAft])
                {
                    counterRight++;
                }
                else break;
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
