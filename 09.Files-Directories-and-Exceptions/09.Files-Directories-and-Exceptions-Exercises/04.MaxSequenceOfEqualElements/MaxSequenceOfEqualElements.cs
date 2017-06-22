namespace _04.MaxSequenceOfEqualElements
{
    using System.Collections.Generic;
    using System.IO;
    using System.Linq;

    public class MaxSequenceOfEqualElements
    {
        public static void Main()
        {
            int[] numbers = File.ReadAllText("input.txt").Split(' ').Select(int.Parse).ToArray();

            int longestSequence = 0;
            int longestSeqMember = 0;

            for (int i = 0; i < numbers.Length; i++)
            {
                int currentNum = numbers[i];

                int currentLongestSeq = 1;

                for (int j = i + 1; j < numbers.Length; j++)
                {
                    if (currentNum == numbers[j])
                    {
                        currentLongestSeq++;
                    }
                    else
                    {
                        break;
                    }
                }

                if (currentLongestSeq > longestSequence)
                {
                    longestSequence = currentLongestSeq;
                    longestSeqMember = numbers[i];
                }
            }

            var output = new List<int>();

            for (int i = 0; i < longestSequence; i++)
            {
                output.Add(longestSeqMember);
            }

            File.WriteAllText("output.txt",string.Join(" ", output));
        }
    }
}
