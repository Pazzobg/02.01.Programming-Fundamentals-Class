namespace _04.CharacterMultiplier
{
    using System;

    public class CharacterMultiplier
    {
        public static void Main()
        {
            var input = Console.ReadLine().Split(' ');

            string inputOne = input[0];
            string inputTwo = input[1];
            int loopEnd = Math.Min(inputOne.Length, inputTwo.Length);

            int result = 0;

            for (int i = 0; i < loopEnd; i++)
            {
                result += inputOne[i] * inputTwo[i];
            }

            if (loopEnd == inputTwo.Length)
            {
                for (int i = loopEnd; i < inputOne.Length; i++)
                {
                    result += inputOne[i];
                }
            }
            else
            {
                for (int i = loopEnd; i < inputTwo.Length; i++)
                {
                    result += inputTwo[i];
                }
            }

            Console.WriteLine(result);
        }
    }
}
