namespace _02.ArrayManipulator
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class ArrayManipulator
    {
        public static void Main()
        {
            int[] numbers = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();

            string[] input = Console.ReadLine().Split(' ');

            while (input[0] != "end")
            {
                string command = input[0];
                switch (command)
                {
                    case "exchange":
                        ExchageArrayElements(numbers, input); break;
                    case "max":
                        CalculateIndexOfMaxEvenOddElement(numbers, input); break;
                    case "min":
                        CalculateIndexOfMinEvenOddElement(numbers, input); break;
                    case "first":
                        CalculateFirstEvenOddElements(numbers, input); break;
                    case "last":
                        CalculateLastEvenOddElements(numbers, input); break;
                }

                input = Console.ReadLine().Split(' ');
            }

            Console.WriteLine($"[{string.Join(", ", numbers)}]");
        }

        public static void ExchageArrayElements(int[] numbers, string[] input)
        {
            int index = int.Parse(input[1]);

            if (index < 0 || index > numbers.Length - 1)
            {
                Console.WriteLine("Invalid index");
                return;
            }

            int loopEnd = numbers.Length - 1 - index;
            for (int i = 0; i < loopEnd; i++)
            {
                int temp = numbers[numbers.Length - 1];

                for (int j = numbers.Length - 1; j > 0; j--)
                {
                    numbers[j] = numbers[j - 1];
                }

                numbers[0] = temp;
            }
        }

        public static void CalculateIndexOfMaxEvenOddElement(int[] numbers, string[] input)
        {
            string oddOrEven = input[1];

            int maxNum = -1;

            if (oddOrEven == "even" && numbers.Any(x => x % 2 == 0))
            {
                maxNum = numbers.Where(x => x % 2 == 0).Max();
            }
            else if (oddOrEven == "odd" && numbers.Any(x => x % 2 != 0))
            {
                maxNum = numbers.Where(x => x % 2 != 0).Max();
            }

            Console.WriteLine(maxNum > -1 ? Array.LastIndexOf(numbers, maxNum).ToString() : "No matches");
        }

        public static void CalculateIndexOfMinEvenOddElement(int[] numbers, string[] input)
        {
            string oddOrEven = input[1];

            int maxNum = -1;

            if (oddOrEven == "even" && numbers.Any(x => x % 2 == 0))
            {
                maxNum = numbers.Where(x => x % 2 == 0).Min();
            }
            else if (oddOrEven == "odd" && numbers.Any(x => x % 2 != 0))
            {
                maxNum = numbers.Where(x => x % 2 != 0).Min();
            }

            Console.WriteLine(maxNum > -1 ? Array.LastIndexOf(numbers, maxNum).ToString() : "No matches");
        }

        public static void CalculateFirstEvenOddElements(int[] numbers, string[] input)
        {
            int count = int.Parse(input[1]);

            if (count > numbers.Length)
            {
                Console.WriteLine("Invalid count");
                return;
            }

            string oddOrEven = input[2];

            var output = new List<int>();

            if (oddOrEven == "even")
            {
                output = numbers.Where(x => x % 2 == 0).Take(count).ToList();
            }
            else if (oddOrEven == "odd")
            {
                output = numbers.Where(x => x % 2 != 0).Take(count).ToList();
            }

            Console.WriteLine($"[{string.Join(", ", output)}]");
        }

        public static void CalculateLastEvenOddElements(int[] numbers, string[] input)
        {
            int count = int.Parse(input[1]);

            if (count > numbers.Length)
            {
                Console.WriteLine("Invalid count");
                return;
            }

            string oddOrEven = input[2];

            var output = new List<int>();

            if (oddOrEven == "even")
            {
                output = numbers.Where(x => x % 2 == 0).Reverse().Take(count).Reverse().ToList();
            }
            else if (oddOrEven == "odd")
            {
                output = numbers.Where(x => x % 2 != 0).Reverse().Take(count).Reverse().ToList();
            }

            Console.WriteLine($"[{string.Join(", ", output)}]");
        }
    }
}
