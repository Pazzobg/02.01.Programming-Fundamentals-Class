namespace _03.SearchForANumber
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class SearchForANumber
    {
        public static void Main()
        {
            var numbers = Console.ReadLine().Split(' ').Select(int.Parse).ToList();

            int[] elements = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();

            int numsToTake = elements[0];
            int numsToRemove = elements[1];
            int numToLookFor = elements[2];

            List<int> result = numbers.Take(numsToTake).ToList();

            result.RemoveRange(0, numsToRemove);

            if (result.Contains(numToLookFor))
            {
                Console.WriteLine("YES!");
            }
            else
            {
                Console.WriteLine("NO!");
            }
        }
    }
}
