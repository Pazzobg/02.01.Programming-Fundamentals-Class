namespace _07.TakeSkipRope
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class TakeSkipRope
    {
        public static void Main()
        {
            var input = Console.ReadLine().ToList();

            var numsList = new List<int>();
            var nonNumbers = new List<char>();

            foreach (var character in input)
            {
                if (char.IsDigit(character))
                {
                    numsList.Add(int.Parse(character.ToString()));
                }
                else
                {
                    nonNumbers.Add(character);
                }
            }

            var takeList = new List<int>();
            var skipList = new List<int>();

            for (int i = 0; i < numsList.Count; i++)
            {
                if (i % 2 == 0)
                {
                    takeList.Add(numsList[i]);
                }
                else
                {
                    skipList.Add(numsList[i]);
                }
            }

            var resultList = new List<char>();
            int numsToSkip = 0;
            int numsToTake = 0;
            int totalNumsSkip = 0;

            for (int i = 0; i < takeList.Count; i++)
            {
                totalNumsSkip += numsToSkip + numsToTake;   // 0 += 0 + 0   0 += 4 + 0 = 4      4 += 1 + 4 = 9

                numsToSkip = skipList[i];                   // 4            1                   0
                numsToTake = takeList[i];                   // 0            4                   7

                resultList.AddRange(nonNumbers
                    .Skip(totalNumsSkip)
                    .Take(numsToTake));
            }

            Console.WriteLine(string.Join(string.Empty, resultList));
        }
    }
}
