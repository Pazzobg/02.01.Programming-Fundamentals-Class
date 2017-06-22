namespace _03.EqualSums
{
    using System.IO;
    using System.Linq;

    public class EqualSums
    {
        public static void Main()
        {
            var numbers = File.ReadAllText("input.txt").Split(' ').Select(int.Parse).ToArray();

            int neededIndex = int.MinValue;

            for (int i = 0; i < numbers.Length; i++)
            {
                int currentNum = numbers[i];

                int sumLeft = 0;

                for (int j = 0; j < i; j++)
                {
                    sumLeft += numbers[j];
                }

                int sumRight = 0;

                if (i != numbers.Length - 1)
                {
                    for (int j = i + 1; j < numbers.Length; j++)
                    {
                        sumRight += numbers[j];
                    }
                }

                if (sumLeft == sumRight)
                {
                    neededIndex = i;
                }
            }

            string output = string.Empty;

            output = neededIndex > -1 ? neededIndex.ToString() : "no";

            File.WriteAllText("output.txt", output);
        }
    }
}
