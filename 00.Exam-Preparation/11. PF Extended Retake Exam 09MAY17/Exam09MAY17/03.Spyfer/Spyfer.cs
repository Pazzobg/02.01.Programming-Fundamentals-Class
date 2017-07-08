namespace _03.Spyfer
{
    using System;
    using System.Linq;

    public class Spyfer
    {
        public static void Main()
        {
            var numbers = Console.ReadLine()
                .Split(new[] { ' ', '\t' }, StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToList();

            for (int i = 0; i < numbers.Count; i++)
            {
                if (i == 0 && numbers.Count > 1)
                {
                    if (numbers[0] == numbers[1])
                    {
                        numbers.RemoveAt(1);
                        i = -1;
                        continue;
                    }
                }
                else if (i > 0 && i < numbers.Count - 1)
                {
                    int sumSurroundingElements = numbers[i - 1] + numbers[i + 1];
                    if (numbers[i] == sumSurroundingElements)
                    {
                        numbers.RemoveAt(i + 1);
                        numbers.RemoveAt(i - 1);
                        i = -1;
                        continue;
                    }
                }
                else if (i == numbers.Count - 1 && numbers.Count > 1)
                {
                    if (numbers[numbers.Count - 2] == numbers[numbers.Count - 1])
                    {
                        numbers.RemoveAt(numbers.Count - 2);
                        i = -1;
                        continue;
                    }
                }
            }

            Console.WriteLine(string.Join(" ", numbers));
        }
    }
}
