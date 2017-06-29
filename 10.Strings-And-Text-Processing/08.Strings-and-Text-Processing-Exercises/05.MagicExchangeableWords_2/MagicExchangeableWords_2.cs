namespace _05.MagicExchangeableWords_2
{
    using System;
    using System.Linq;

    public class MagicExchangeableWords_2
    {
        public static void Main()
        {
            string[] words = Console.ReadLine().Split(' ');
            string firstWord = words[0];
            string secondWord = words[1];
            bool exchangeable = true;

            int loopEnd = Math.Min(firstWord.Length, secondWord.Length);

            int firstLength = firstWord.ToCharArray().Distinct().Count();
            int secondLenth = secondWord.ToCharArray().Distinct().Count();

            if (firstLength != secondLenth)
            {
                exchangeable = false;
            }
            else
            {
                for (int i = 1; i < loopEnd; i++)
                {
                    bool check1 = firstWord[i] == firstWord[i - 1];
                    bool check2 = secondWord[i] == secondWord[i - 1];

                    if (check2 != check1)
                    {
                        exchangeable = false;
                        break;
                    }
                }
            }

            Console.WriteLine(exchangeable ? "true" : "false");
        }
    }
}
