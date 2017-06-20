namespace _02.RandomizeWords
{
    using System;

    public class RandomizeWords
    {
        public static void Main()
        {
            string[] input = Console.ReadLine().Split(' ');

            var random = new Random();

            for (int i = 0; i < input.Length; i++)
            {
                int randomPosition = random.Next(0, input.Length);

                string temp = input[i];
                input[i] = input[randomPosition];
                input[randomPosition] = temp;
            }

            Console.WriteLine(string.Join("\n", input));
        }
    }
}
