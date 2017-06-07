namespace _12.MasterNumber
{
    using System;

    public class MasterNumber
    {
        public static void Main()
        {
            int n = int.Parse(Console.ReadLine());

            for (int i = 1; i <= n; i++)
            {
                bool palindrome = CheckIfPalindrome(i);
                bool divisibleToSeven = CheckIfSumDigitsDivisibleBy7(i);
                bool holdsEvenDigit = CheckIfHoldsEvenDigit(i);

                if (palindrome && divisibleToSeven && holdsEvenDigit)
                {
                    Console.WriteLine(i);
                }
            }
        }

        public static bool CheckIfPalindrome(int i)
        {
            string inputToString = i.ToString();
            int loopEnd = inputToString.Length / 2;

            for (int j = 0; j < loopEnd; j++)
            {
                if (inputToString[j] != inputToString[inputToString.Length - 1 - j])
                {
                    return false;
                }
            }

            return true;
        }

        public static bool CheckIfSumDigitsDivisibleBy7(int i)
        {
            int sum = 0;

            foreach (char symbol in i.ToString())
            {
                int digit = symbol - '0';
                sum += digit;
            }

            bool divisibleBySeven = sum % 7 == 0 ? true : false;

            return divisibleBySeven;
        }

        public static bool CheckIfHoldsEvenDigit(int i)
        {
            bool holdsEvenDigit = false;

            while (i > 0)
            {
                int result = i % 10;

                if (result % 2 == 0)
                {
                    holdsEvenDigit = true;
                    break;
                }

                i /= 10;
            }

            return holdsEvenDigit;
        }
    }
}
