namespace _03.SafeManipulation
{
    using System;

    public class SafeManipulation
    {
        public static void Main()
        {
            string[] inputArr = Console.ReadLine().Split(' ');

            string[] command = Console.ReadLine().Split(' ');

            while (command[0] != "END")
            {
                if (command[0] == "Reverse")
                {
                    ReverseArray(inputArr, command);
                }
                else if (command[0] == "Distinct")
                {
                    inputArr = GetDistinctElements(inputArr, command);
                }
                else if (command[0] == "Replace")
                {
                    ReplaceCertainElement(inputArr, command);
                }
                else
                {
                    Console.WriteLine("Invalid input!");
                }

                command = Console.ReadLine().Split(' ');
            }

            Console.WriteLine(string.Join(", ", inputArr));
        }

        public static void ReverseArray(string[] inputArr, string[] command)
        {
            for (int i = 0; i < inputArr.Length / 2; i++)
            {
                string tempValue = inputArr[i];

                inputArr[i] = inputArr[inputArr.Length - 1 - i];
                inputArr[inputArr.Length - 1 - i] = tempValue;
            }
        }

        public static string[] GetDistinctElements(string[] inputArr, string[] command)
        {
            int size = inputArr.Length;

            for (int i = 0; i < inputArr.Length; i++)
            {
                if (inputArr[i] != null)
                {
                    for (int j = i + 1; j < inputArr.Length; j++)
                    {
                        if (inputArr[i] == inputArr[j])
                        {
                            inputArr[j] = null;
                            size--;
                        }
                    }
                }
            }

            string[] newArray = new string[size];
            int counter = 0;

            for (int i = 0; i < inputArr.Length; i++)
            {
                if (inputArr[i] != null)
                {
                    newArray[counter] = inputArr[i];
                    counter++;
                }
            }

            return newArray;
        }

        public static void ReplaceCertainElement(string[] inputArr, string[] command)
        {
            int index = int.Parse(command[1]);
            string newValue = command[2];
            if (index >= 0 && index < inputArr.Length)
            {
                inputArr[index] = newValue;
            }
            else
            {
                Console.WriteLine("Invalid input!");
                return;
            }
        }
    }
}
