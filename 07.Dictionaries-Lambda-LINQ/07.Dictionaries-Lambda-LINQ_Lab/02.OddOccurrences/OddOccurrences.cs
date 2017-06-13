namespace _02.OddOccurrences
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class OddOccurrences
    {
        public static void Main()
        {
            var input = Console.ReadLine().ToLower().Split(' ').ToArray();

            var counterDict = new Dictionary<string, int>();

            for (int i = 0; i < input.Length; i++)
            {
                if (!counterDict.ContainsKey(input[i]))
                {
                    counterDict[input[i]] = 0;
                }

                counterDict[input[i]]++;
            }

            var resultList = new List<string>();

            foreach (var kvp in counterDict)
            {
                if (kvp.Value % 2 != 0)
                {
                    resultList.Add(kvp.Key);
                }
            }

            Console.WriteLine(string.Join(", ", resultList));
        }
    }
}
