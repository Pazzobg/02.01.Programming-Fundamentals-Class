namespace _18.SequenceOfCommands_Debugging
{
    using System;
    using System.Linq;

    public class SequenceOfCommands_Debugging
    {
        public static void Main()
        {
            int sizeOfArray = int.Parse(Console.ReadLine());

            long[] array = Console.ReadLine()
                .Split(' ')
                .Select(long.Parse)
                .ToArray();

            string line = Console.ReadLine();

            while (line != "stop")
            {
                int[] args = new int[2];

                string[] input = line.Trim().Split();

                string command = input[0];

                if (command.Equals("add") ||
                    command.Equals("subtract") ||
                    command.Equals("multiply"))
                {
                    args[0] = int.Parse(input[1]);
                    args[1] = int.Parse(input[2]);
                }

                PerformAction(array, command, args);

                PrintArray(array);

                line = Console.ReadLine();
            }
        }

        public static void PerformAction(long[] array, string action, int[] args)
        {
            int position = args[0] - 1;
            int value = args[1];

            switch (action)
            {
                case "multiply":
                    array[position] *= value;
                    break;
                case "add":
                    array[position] += value;
                    break;
                case "subtract":
                    array[position] -= value;
                    break;
                case "lshift":
                    ArrayShiftLeft(array);
                    break;
                case "rshift":
                    ArrayShiftRight(array);
                    break;
            }
        }

        public static void ArrayShiftLeft(long[] array)
        {
            long firstValue = array[0];

            for (int i = 0; i < array.Length - 1; i++)
            {
                array[i] = array[i + 1];
            }

            array[array.Length - 1] = firstValue;
        }

        public static void ArrayShiftRight(long[] array)
        {
            long lastValue = array[array.Length - 1];

            for (int i = array.Length - 1; i >= 1; i--)
            {
                array[i] = array[i - 1];
            }

            array[0] = lastValue;
        }

        public static void PrintArray(long[] array)
        {
            Console.WriteLine(string.Join(" ", array));
        }
    }
}
