namespace _02.TrophonTheGrumpyCat
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class TrophonTheGrumpyCat
    {
        public static void Main()
        {
            long[] numbers = Console.ReadLine().Split(new[] { ' ', '\t' }, StringSplitOptions.RemoveEmptyEntries).Select(long.Parse).ToArray();
            int entryPoint = int.Parse(Console.ReadLine());
            long entryValue = numbers[entryPoint];
            string typeOfItems = Console.ReadLine();
            string typeOfPriceIndexes = Console.ReadLine();

            long sumLeft = 0;
            long sumRight = 0;

            var rightSide = new List<long>();
            for (int i = entryPoint + 1; i < numbers.Length; i++)
            {
                rightSide.Add(numbers[i]);
            }

            var leftSide = new List<long>();
            for (int i = entryPoint - 1; i >= 0; i--)
            {
                leftSide.Add(numbers[i]);
            }

            switch (typeOfItems)
            {
                case "cheap":
                    switch (typeOfPriceIndexes)
                    {
                        case "positive":
                            sumRight = rightSide
                                .Where(x => x < entryValue)
                                .Where(x => x > 0)
                                .Sum();
                            sumLeft = leftSide
                                .Where(x => x < entryValue)
                                .Where(x => x > 0)
                                .Sum();
                            break;
                        case "negative":
                            sumRight = rightSide
                                .Where(x => x < entryValue)
                                .Where(x => x < 0)
                                .Sum();
                            sumLeft = leftSide
                                .Where(x => x < entryValue)
                                .Where(x => x < 0)
                                .Sum();
                            break;
                        case "all":
                            sumRight = rightSide
                                .Where(x => x < entryValue)
                                .Sum();
                            sumLeft = leftSide
                               .Where(x => x < entryValue)
                               .Sum();
                            break;
                    }
                    break;

                case "expensive":
                    switch (typeOfPriceIndexes)
                    {
                        case "positive":
                            sumRight = rightSide
                                .Where(x => x >= entryValue)
                                .Where(x => x > 0)
                                .Sum();
                            sumLeft = leftSide
                                .Where(x => x >= entryValue)
                                .Where(x => x > 0)
                                .Sum();
                            break;
                        case "negative":
                            sumRight = rightSide
                                .Where(x => x >= entryValue)
                                .Where(x => x < 0)
                                .Sum();
                            sumLeft = leftSide
                                .Where(x => x >= entryValue)
                                .Where(x => x < 0)
                                .Sum();
                            break;
                        case "all":
                            sumRight = rightSide
                                .Where(x => x >= entryValue)
                                .Sum();
                            sumLeft = leftSide
                               .Where(x => x >= entryValue)
                               .Sum();
                            break;
                    }
                    break;
            }

            Console.WriteLine(sumLeft >= sumRight ? $"Left - {sumLeft}" : $"Right - {sumRight}");
        }
    }
}
