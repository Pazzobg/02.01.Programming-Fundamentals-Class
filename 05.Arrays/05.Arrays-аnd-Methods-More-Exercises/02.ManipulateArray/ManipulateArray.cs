namespace _02.ManipulateArray
{
    using System;

    public class ManipulateArray
    {
        public static void Main()
        {
            string[] inputArray = Console.ReadLine().Split(' ');

            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                string[] command = Console.ReadLine().Split(' ');

                if (command[0] == "Reverse")
                {
                    ReverseArray(inputArray);
                }
                else if (command[0] == "Distinct")
                {
                    inputArray = GetDistinctElements(inputArray);
                }
                else if (command[0] == "Replace")
                {
                    ReplaceCertainElement(inputArray, command);
                }
            }

            Console.WriteLine(string.Join(", ", inputArray));
        }

        public static void ReverseArray(string[] inputArray)
        {
            for (int i = 0; i < inputArray.Length / 2; i++)
            {
                string tempValue = inputArray[i];

                inputArray[i] = inputArray[inputArray.Length - 1 - i];
                inputArray[inputArray.Length - 1 - i] = tempValue;
            }
        }

        public static string[] GetDistinctElements(string[] inputArray)
        {
            int size = inputArray.Length;

            for (int i = 0; i < inputArray.Length; i++)
            {
                if (inputArray[i] != null)
                {
                    for (int j = i + 1; j < inputArray.Length; j++)
                    {
                        if (inputArray[i] == inputArray[j])
                        {
                            inputArray[j] = null;
                            size--;
                        }
                    }
                }
            }

            string[] newArray = new string[size];
            int counter = 0;

            for (int i = 0; i < inputArray.Length; i++)
            {
                if (inputArray[i] != null)
                {
                    newArray[counter] = inputArray[i];
                    counter++;
                }
            }

            return newArray;
        }

        public static void ReplaceCertainElement(string[] inputArray, string[] command)
        {
            int index = int.Parse(command[1]);
            string newValue = command[2];

            inputArray[index] = newValue;
        }
    }
}
