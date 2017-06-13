namespace _16.InstructionSet_Debugging
{
    using System;

    public class InstructionSet_Debugging
    {
        public static void Main()
        {
            string input = Console.ReadLine().ToUpper();

            while (input != "END")
            {
                string[] inputArgs = input.Split(' ');

                string operation = inputArgs[0];

                long result = 0L;
                long operandOne = 0;
                long operandTwo = 0;

                switch (operation)
                {
                    case "INC":
                            operandOne = long.Parse(inputArgs[1]);
                            result = ++operandOne;
                            break;
                    case "DEC":
                            operandOne = long.Parse(inputArgs[1]);
                            result = --operandOne;
                            break;
                    case "ADD":
                            operandOne = long.Parse(inputArgs[1]);
                            operandTwo = long.Parse(inputArgs[2]);
                            result = operandOne + operandTwo;
                            break;
                    case "MLA":
                            operandOne = long.Parse(inputArgs[1]);
                            operandTwo = long.Parse(inputArgs[2]);
                            result = operandOne * operandTwo;
                            break;
                }

                Console.WriteLine(result);
                input = Console.ReadLine().ToUpper();
            }
        }
    }
}
