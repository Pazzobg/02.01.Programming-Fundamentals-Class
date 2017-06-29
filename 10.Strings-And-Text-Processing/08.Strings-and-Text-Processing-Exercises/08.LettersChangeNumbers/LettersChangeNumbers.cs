namespace _08.LettersChangeNumbers
{
    using System;

    public class LettersChangeNumbers
    {
        public static void Main()
        {
            string[] input = Console.ReadLine().Split(" \t".ToCharArray(), StringSplitOptions.RemoveEmptyEntries);
            double sum = 0;

            for (int i = 0; i < input.Length; i++)
            {
                string currentString = input[i];

                double currentResult = DoActionAccordingLetterBefore(currentString);

                currentResult = DoActionAccordingLetterAft(currentResult, currentString);

                sum += currentResult;
            }

            Console.WriteLine($"{sum:f2}");
        }

        public static double DoActionAccordingLetterBefore(string currentString)
        {
            double result = 0;
            char letter = currentString[0];
            string action = string.Empty;
            string numToParse = currentString.Substring(1, currentString.Length - 2);

            double operand = double.Parse(numToParse);
            int operatorNum = 0;

            if (char.IsUpper(letter))
            {
                action = "division";
                operatorNum = letter - 64;
            }
            else if (char.IsLower(letter))
            {
                action = "multiplication";
                operatorNum = letter - 96;
            }

            switch (action)
            {
                case "division":
                    result = operand / operatorNum;
                    break;
                case "multiplication":
                    result = operand * operatorNum;
                    break;
            }

            return result;
        }

        public static double DoActionAccordingLetterAft(double currentResult, string currentString)
        {
            char letter = currentString[currentString.Length - 1];
            string action = string.Empty;

            int operatorNum = 0;

            if (char.IsUpper(letter))
            {
                action = "subtraction";
                operatorNum = letter - 64;
            }
            else if (char.IsLower(letter))
            {
                action = "addition";
                operatorNum = letter - 96;
            }

            switch (action)
            {
                case "subtraction":
                    currentResult -= operatorNum;
                    break;
                case "addition":
                    currentResult += operatorNum;
                    break;
            }

            return currentResult;
        }
    }
}
