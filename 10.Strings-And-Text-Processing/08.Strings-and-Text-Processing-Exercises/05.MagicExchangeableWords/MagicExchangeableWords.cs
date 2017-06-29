namespace _05.MagicExchangeableWords
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class MagicExchangeableWords
    {
        public static void Main()
        {
            var words = Console.ReadLine().Split(' ');

            bool exchangeable = CheckIfBothStringExchangeable(words[0], words[1]);

            Console.WriteLine(exchangeable ? "true" : "false");
        }

        public static bool CheckIfBothStringExchangeable(string stringOne, string stringTwo)
        {
            var map = new Dictionary<char, char>();
            int loopEnd = Math.Min(stringOne.Length, stringTwo.Length);

            for (int i = 0; i < loopEnd; i++)
            {
                if (!map.ContainsKey(stringOne[i]))
                {
                    if (map.ContainsValue(stringTwo[i]))
                    {
                        return false;
                    }

                    map[stringOne[i]] = stringTwo[i];
                }
                else
                {
                    if (map[stringOne[i]] != stringTwo[i])
                    {
                        return false;
                    }
                }
            }

            if (stringOne.Length == stringTwo.Length)
            {
                return true;
            }

            string substr = string.Empty;

            if (stringOne.Length > stringTwo.Length)
            {
                substr = stringOne.Substring(loopEnd);
            }
            else if (stringOne.Length < stringTwo.Length)
            {
                substr = stringTwo.Substring(loopEnd);
            }

            bool isContained = true;

            foreach (char c in substr)
            {
                if (!map.Keys.Contains(c) && (!map.Values.Contains(c)))
                {
                    isContained = false;
                    break;
                }
            }

            return isContained ? true : false;
        }
    }
}
