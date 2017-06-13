namespace _02.ChangeList
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class ChangeList
    {
        public static void Main()
        {
            var numbers = Console.ReadLine().Split(' ').Select(int.Parse).ToList();

            string[] input = Console.ReadLine().ToLower().Split(' ');

            while (input[0] != "odd" && input[0] != "even")
            {
                switch (input[0])
                {
                    case "delete":
                        DeleteElement(numbers, input);
                        break;
                    case "insert":
                        InsertElement(numbers, input);
                        break;
                }

                input = Console.ReadLine().ToLower().Split(' ');
            }

            for (int i = 0; i < numbers.Count; i++)
            {
                switch (input[0])
                {
                    case "odd":
                        if (numbers[i] % 2 != 0)
                        {
                            Console.Write($"{numbers[i]} ");
                        }
                        break;
                    case "even":
                        if (numbers[i] % 2 == 0)
                        {
                            Console.Write($"{numbers[i]} ");
                        }
                        break;
                }
            }

            Console.WriteLine();
        }

        public static void DeleteElement(List<int> numbers, string[] input)
        {
            int element = int.Parse(input[1]);

            numbers.RemoveAll(x => x == element);
        }

        public static void InsertElement(List<int> numbers, string[] input)
        {
            int element = int.Parse(input[1]);
            int index = int.Parse(input[2]);

            numbers.Insert(index, element);
        }
    }
}
