namespace _09.ExtractMiddleOneTwoOrThreeElements
{
    using System;

    public class ExtractMiddleOneTwoOrThreeElements
    {
        public static void Main()
        {
            string[] line = Console.ReadLine().Split(' ');
            int[] numbersArr = new int[line.Length];
            for (int i = 0; i < line.Length; i++)
            {
                numbersArr[i] = int.Parse(line[i]);
            }

            string output = string.Empty;

            if (numbersArr.Length == 1)
            {
                output = ExtractSingleElement(numbersArr);
            }
            else if (numbersArr.Length != 1 && numbersArr.Length % 2 == 0)
            {
                output = ExtractTwoElements(numbersArr);
            }
            else
            {
                output = ExtractThreeElements(numbersArr);
            }

            Console.WriteLine($"{{ {output} }}");
        }

        public static string ExtractSingleElement(int[] numbersArr)
        {
            return string.Join(", ", numbersArr);
        }

        public static string ExtractTwoElements(int[] numbersArr)
        {
            int firstMiddle = (numbersArr.Length / 2) - 1;
            int secondMiddle = numbersArr.Length / 2;

            return string.Join(", ", numbersArr[firstMiddle], numbersArr[secondMiddle]);
        }

        public static string ExtractThreeElements(int[] numbersArr)
        {
            int firstMiddle = (numbersArr.Length / 2) - 1;
            int secondMiddle = (numbersArr.Length / 2);
            int thirdMiddle = (numbersArr.Length / 2) + 1;

            return string.Join(", ", numbersArr[firstMiddle], numbersArr[secondMiddle], numbersArr[thirdMiddle]);
        }
    }
}
