namespace _04.LongestIncreasingSubsequence
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class LongestIncreasingSubsequence
    {
        public const int NoPrevNumbers = -1;

        public static void Main()
        {
            //int[] sequence = { 3, 4, 8, 1, 2, 4, 32, 6, 2, 5, 33, 4, 38, 22 };
            int[] sequence = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            int[] length = new int[sequence.Length];
            int[] previous = new int[sequence.Length];

            int bestIndex = CalculateLongestIncreasingSubsequence(sequence, length, previous);

            //Console.WriteLine("sequence[] = " + string.Join(", ", sequence));
            //Console.WriteLine("length[] = " + string.Join(", ", length));
            //Console.WriteLine("previous[] = " + string.Join(", ", previous));

            PrintLongestIncreasingSubsequence(sequence, previous, bestIndex);
        }

        public static int CalculateLongestIncreasingSubsequence(int[] sequence, int[] length, int[] previous)
        {
            int maxIndex = 0;
            int maxLength = 0;

            for (int currentNum = 0; currentNum < sequence.Length; currentNum++) // checks for each number from the seq
            {
                length[currentNum] = 1;
                previous[currentNum] = -1;

                for (int leftNumCheck = 0; leftNumCheck < currentNum; leftNumCheck++) // check for all numbers, that are left from the currentNum
                {                                                         // if they have lower value than the current num
                    if (sequence[currentNum] > sequence[leftNumCheck] && length[leftNumCheck] + 1 > length[currentNum])
                    {                                                     // and if their sequence length would be longer
                        length[currentNum] = length[leftNumCheck] + 1;    // than the seq length of the currentNum itself. (of the longest sequence up to now)
                        previous[currentNum] = leftNumCheck;
                    }
                }

                if (length[currentNum] > maxLength)
                {
                    maxLength = length[currentNum];
                    maxIndex = currentNum;
                }
            }

            return maxIndex;
        }

        public static void PrintLongestIncreasingSubsequence(int[] sequence, int[] previous, int index)
        {
            var longestSubSequence = new List<int>();

            while (index != NoPrevNumbers)
            {
                longestSubSequence.Add(sequence[index]);
                index = previous[index];
            }

            longestSubSequence.Reverse();
            //Console.WriteLine("subsequence = [{0}]", string.Join(", ", temporaryList));
            Console.WriteLine(string.Join(" ", longestSubSequence));
        }
    }
}
