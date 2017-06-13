namespace _01.RemoveNegativesAndReverse
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class RemoveNegativesAndReverse
    {
        public static void Main()
        {
            var inputList = Console.ReadLine().Split(' ').Select(int.Parse).ToList();

            var resultList = new List<int>();

            foreach (var number in inputList)
            {
                if (number > 0)
                {
                    resultList.Add(number);
                }
            }

            resultList.Reverse();

            if (resultList.Count > 0)
            {
                Console.WriteLine(string.Join(" ", resultList));
            }
            else
            {
                Console.WriteLine("empty");
            }
        }
    }
}
