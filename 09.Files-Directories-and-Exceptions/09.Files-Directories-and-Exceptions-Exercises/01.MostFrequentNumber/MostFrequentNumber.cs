namespace _01.MostFrequentNumber
{
    using System.IO;
    using System.Linq;

    public class MostFrequentNumber
    {
        public static void Main()
        {
            string[] numbersLines = File.ReadAllLines("input.txt");
            string[] resultList = new string[numbersLines.Length];

            for (int i = 0; i < numbersLines.Length; i++)
            {
                int[] numbers = numbersLines[i].Split(' ').Select(int.Parse).ToArray();

                int totalCount = 0;
                int mostFrequentNum = 0;

                for (int j = 0; j < numbers.Length - 1; j++)
                {
                    int currentNum = numbers[j];
                    int counter = 1;

                    for (int k = j + 1; k < numbers.Length; k++)
                    {
                        if (currentNum == numbers[k])
                        {
                            counter++;
                        }
                    }

                    if (counter > totalCount)
                    {
                        totalCount = counter;
                        mostFrequentNum = numbers[j];
                    }
                }

                resultList[i] = mostFrequentNum.ToString();
            }

            File.WriteAllLines("output.txt", resultList);
        }
    }
}