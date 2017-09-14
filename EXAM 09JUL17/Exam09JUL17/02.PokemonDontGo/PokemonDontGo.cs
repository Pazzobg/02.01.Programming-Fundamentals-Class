namespace _02.PokemonDontGo
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class PokemonDontGo
    {
        public static void Main()
        {
            List<long> numbers = Console.ReadLine().Split(new[] { ' ', '\t' }, StringSplitOptions.RemoveEmptyEntries).Select(long.Parse).ToList();

            long sum = 0;

            while (numbers.Count > 0)
            {
                int currentIndex = int.Parse(Console.ReadLine());

                long currentValue = 0;

                if (currentIndex < 0)
                {
                    currentValue = numbers[0];
                    sum += currentValue;
                    numbers[0] = numbers[numbers.Count - 1];
                }
                else if (currentIndex >= numbers.Count)
                {
                    currentValue = numbers[numbers.Count - 1];
                    sum += currentValue;
                    numbers[numbers.Count - 1] = numbers[0];
                }
                else
                {
                    currentValue = numbers[currentIndex];
                    sum += currentValue;
                    numbers.RemoveAt(currentIndex);
                }

                for (int i = 0; i < numbers.Count; i++)
                {
                    if (numbers[i] <= currentValue)
                    {
                        numbers[i] += currentValue;
                    }
                    else
                    {
                        numbers[i] -= currentValue;
                    }
                }
            }

            Console.WriteLine(sum);
        }
    }
}