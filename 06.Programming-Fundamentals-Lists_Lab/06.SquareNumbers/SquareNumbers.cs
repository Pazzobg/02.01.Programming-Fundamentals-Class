namespace _06.SquareNumbers
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class SquareNumbers
    {
        public static void Main()
        {
            var numbers = Console.ReadLine().Split(' ').Select(int.Parse).ToList();
            var resultList = new List<int>();

            foreach (var number in numbers)
            {
                double currentSqrt = Math.Sqrt(number);

                // Check if the square root of the current number results in an integer.
                // Alternatively, as per the given hint, condition could be as follows: 
                // if (Math.Sqrt(number) == (int)Math.Sqrt(number))
                if (currentSqrt % 1 == 0)
                {
                    resultList.Add(number);
                }
            }

            // Sorting the list in descending order. 
            // Alternatively, sorting it without using a lambda-function could be done as follows:
            //resultList.Sort();
            //resultList.Reverse();
            resultList.Sort((a, b) => b.CompareTo(a));

            Console.WriteLine(string.Join(" ", resultList));
        }
    }
}
