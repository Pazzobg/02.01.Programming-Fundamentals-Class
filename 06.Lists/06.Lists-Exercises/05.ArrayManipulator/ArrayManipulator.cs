namespace _05.ArrayManipulator
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class ArrayManipulator
    {
        public static void Main()
        {
            var numbers = Console.ReadLine().Split(' ').Select(int.Parse).ToList();

            string[] input = Console.ReadLine().Split(' ');

            while (input[0] != "print")
            {
                string command = input[0];

                switch (command)
                {
                    case "add": AddEllement(numbers, input); break;
                    case "addMany": AddManyElements(numbers, input); break;
                    case "contains": ContainsElement(numbers, input); break;
                    case "remove": RemoveElement(numbers, input); break;
                    case "shift": ShiftPositions(numbers, input); break;
                    case "sumPairs": SumPairsOfElements(numbers, input); break;
                }

                input = Console.ReadLine().Split(' ');
            }

            Console.WriteLine($"[{string.Join(", ", numbers)}]");
        }

        public static void AddEllement(List<int> numbers, string[] input)
        {
            int index = int.Parse(input[1]);
            int element = int.Parse(input[2]);

            numbers.Insert(index, element);
        }

        public static void AddManyElements(List<int> numbers, string[] input)
        {
            int index = int.Parse(input[1]);

            var subList = new List<int>();

            for (int i = 2; i < input.Length; i++)
            {
                subList.Add(int.Parse(input[i]));
            }

            numbers.InsertRange(index, subList);
        }

        public static void ContainsElement(List<int> numbers, string[] input)
        {
            int elementWanted = int.Parse(input[1]);

            int position = numbers.FindIndex(x => x == elementWanted);

            Console.WriteLine(position);
        }

        public static void RemoveElement(List<int> numbers, string[] input)
        {
            int index = int.Parse(input[1]);

            numbers.RemoveAt(index);
        }

        public static void ShiftPositions(List<int> numbers, string[] input)
        {
            int shift = int.Parse(input[1]);

            for (int i = 0; i < shift; i++)
            {
                int temp = numbers[0];

                for (int j = 0; j < numbers.Count - 1; j++)
                {
                    numbers[j] = numbers[j + 1];
                }

                numbers[numbers.Count - 1] = temp;
            }
        }
        
        public static void SumPairsOfElements(List<int> numbers, string[] input)
        {
            int loopEnd = numbers.Count / 2;
            for (int i = 0; i < loopEnd; i++)
            {
                int next = i + 1;

                numbers[i] += numbers[next];
                numbers.RemoveAt(next);
            }
        }
    }
}
