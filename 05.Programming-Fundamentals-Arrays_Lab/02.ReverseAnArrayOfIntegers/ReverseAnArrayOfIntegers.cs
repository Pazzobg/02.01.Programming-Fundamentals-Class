namespace _02.ReverseAnArrayOfIntegers
{
    using System;

    public class ReverseAnArrayOfIntegers
    {
        public static void Main()
        {
            int n = int.Parse(Console.ReadLine());

            var numsArr = new int[n];

            for (int i = 0; i < n; i++)
            {
                int input = int.Parse(Console.ReadLine());

                numsArr[i] = input;
            }

            var reversedNumsArr = new int[n];

            int j = numsArr.Length - 1;

            for (int i = 0; i <= numsArr.Length - 1; i++)
            {
                reversedNumsArr[i] = numsArr[j];

                j--;
            }

            Console.WriteLine(string.Join(" ", reversedNumsArr));


            /*Alternative solution: 
             *int n = int.Parse(Console.ReadLine());

            var numsArr = new int[n];

            for (int i = 0; i < n; i++)
            {
                int input = int.Parse(Console.ReadLine());

                numsArr[i] = input;
            }

            for (int i = numsArr.Length - 1; i >= 0; i--)
            {
                Console.Write($"{numsArr[i]} ");
            }

            Console.WriteLine();
            */
        }
    }
}
