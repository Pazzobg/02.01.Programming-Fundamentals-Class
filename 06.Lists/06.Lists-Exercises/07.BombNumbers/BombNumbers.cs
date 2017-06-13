namespace _07.BombNumbers
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class BombNumbers
    {
        public static void Main()
        {
            var numbers = Console.ReadLine().Split(' ').Select(int.Parse).ToList();
            string[] line = Console.ReadLine().Split(' ');

            int bomb = int.Parse(line[0]);
            int power = int.Parse(line[1]);

            for (int j = 0; j < numbers.Count; j++)
            {
                if (numbers[j] == bomb)
                {
                    int indexOfBomb = numbers.IndexOf(bomb);

                    int start = Math.Max(0, indexOfBomb - power);
                    int loopEnd = Math.Min(
                        Math.Min((power * 2) + 1, numbers.Count - start), 
                        (indexOfBomb + power + 1));

                    for (int i = 0; i < loopEnd; i++)
                    {
                        numbers.RemoveAt(start);
                    }

                    j = -1;
                }
            }

            Console.WriteLine(numbers.Sum());
        }
    }
}
