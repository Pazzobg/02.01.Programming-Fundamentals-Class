namespace _02.CommandInterpreter
{
    using System;
    using System.Linq;

    public class CommandInterpreter
    {
        public static void Main()
        {
            string[] elements = Console.ReadLine()
                .Split(new[] { ' ', '\t' }, StringSplitOptions.RemoveEmptyEntries); 

            string line = Console.ReadLine();

            while (line != "end")
            {
                string[] input = line.Split();
                string command = input[0];

                switch (command)
                {
                    case "reverse":
                        int reverseIndex = int.Parse(input[2]);
                        int reverseCount = int.Parse(input[4]);
                        bool reverseIsValid = CheckForValidityTwoParams(elements, reverseIndex, reverseCount);

                        if (!reverseIsValid)
                        {
                            line = InformUserInvalidParams();
                            continue;
                        }

                        Array.Reverse(elements, reverseIndex, reverseCount);
                        break;

                    case "sort":
                        int sortIndex = int.Parse(input[2]);
                        int sortCount = int.Parse(input[4]);
                        bool sortIsValid = CheckForValidityTwoParams(elements, sortIndex, sortCount);

                        if (!sortIsValid)
                        {
                            line = InformUserInvalidParams();
                            continue;
                        }

                        Array.Sort(elements, sortIndex, sortCount);
                        break;

                    case "rollLeft":
                        int numberRollsLeft = int.Parse(input[1]);
                        bool rollLeftIsValid = CheckForValidityOneParam(elements, numberRollsLeft);

                        if (!rollLeftIsValid)
                        {
                            line = InformUserInvalidParams();
                            continue;
                        }

                        int actualRollsLeft = numberRollsLeft % elements.Length;

                        for (int i = 0; i < actualRollsLeft; i++)
                        {
                            string memory = elements[0];

                            for (int j = 0; j < elements.Length - 1; j++)
                            {
                                elements[j] = elements[j + 1];
                            }

                            elements[elements.Length - 1] = memory;
                        }

                        break;

                    case "rollRight":
                        int numbersRollRight = int.Parse(input[1]);
                        bool rollRightIsValid = CheckForValidityOneParam(elements, numbersRollRight);

                        if (!rollRightIsValid)
                        {
                            line = InformUserInvalidParams();
                            continue;
                        }

                        int actualrRollsRight = numbersRollRight % elements.Length;

                        for (int i = 0; i < actualrRollsRight; i++)
                        {
                            string memory = elements[elements.Length - 1];

                            for (int j = elements.Length - 1; j > 0; j--)
                            {
                                elements[j] = elements[j - 1];
                            }

                            elements[0] = memory;
                        }

                        break;
                }

                line = Console.ReadLine();
            }

            Console.WriteLine($"[{string.Join(", ", elements)}]");
        }

        public static string InformUserInvalidParams()
        {
            Console.WriteLine("Invalid input parameters.");
            return Console.ReadLine();
        }

        public static bool CheckForValidityTwoParams(string[] elements, int startIndex, int count)
        {
            return (startIndex >= 0 && startIndex <= elements.Length - 1)
                && (startIndex + count <= elements.Length)
                && (count >= 0);
        }

        public static bool CheckForValidityOneParam(string[] elements, int countOfRolls)
        {
            return countOfRolls >= 0;
        }
    }
}
