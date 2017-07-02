namespace _04.MorseCodeUpgraded
{
    using System;
    using System.Text;

    public class MorseCodeUpgraded
    {
        public static void Main()
        {
            string[] input = Console.ReadLine().Split('|');
            var sb = new StringBuilder();

            for (int i = 0; i < input.Length; i++)
            {
                string currentLine = input[i];
                int currentSum = 0;

                for (int j = 0; j < currentLine.Length; j++)
                {
                    char currentChar = currentLine[j];

                    switch (currentChar)
                    {
                        case '0': currentSum += 3; break;
                        case '1': currentSum += 5; break;
                    }
                }

                int consecutiveDigits = 1;

                for (int j = 0; j < currentLine.Length - 1; j++)
                {

                    if (currentLine[j] == currentLine[j + 1])
                    {
                        consecutiveDigits++;
                    }
                    else
                    {
                        if (consecutiveDigits > 1)
                        {
                            currentSum += consecutiveDigits;
                            consecutiveDigits = 1;
                        }
                    }
                }

                if (consecutiveDigits > 1)
                {
                    currentSum += consecutiveDigits;
                }

                sb.Append((char)currentSum);
            }

            Console.WriteLine(sb.ToString());
        }
    }
}
