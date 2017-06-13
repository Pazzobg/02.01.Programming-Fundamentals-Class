namespace _07.CountNumbers_3_UsingDictionary
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class CountNumbers
    {
        public static void Main()
        {
            var numbers = Console.ReadLine().Split(' ').Select(int.Parse).ToList();

            var countsDict = new Dictionary<int, int>();

            foreach (var number in numbers)
            {
                if (!countsDict.ContainsKey(number))
                {
                    countsDict[number] = 0;
                }

                countsDict[number]++;
            }

            foreach (var kvp in countsDict.OrderBy(n => n.Key))
            {
                int number = kvp.Key;
                int count = kvp.Value;

                Console.WriteLine($"{number} -> {count}");
            }
        }
    }
}
