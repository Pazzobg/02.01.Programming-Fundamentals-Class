namespace _05.CompareCharArrays
{
    using System;
    using System.Linq;

    public class CompareCharArrays
    {
        public static void Main()
        {
            char[] charArrFirst = Console.ReadLine().Split(' ').Select(char.Parse).ToArray();
            char[] charArrSecond = Console.ReadLine().Split(' ').Select(char.Parse).ToArray();

            bool equal = true;
            string printWinner = string.Empty;

            int shorterArrLength = Math.Min(charArrFirst.Length, charArrSecond.Length);

            for (int i = 0; i < shorterArrLength; i++)
            {
                if (charArrFirst[i] != charArrSecond[i])
                {
                    printWinner = charArrFirst[i] < charArrSecond[i] ? "first" : "second";

                    equal = false;
                    break;
                }
            }

            if (!equal)
            {
                if (printWinner == "first")
                {
                    Console.WriteLine(string.Join(string.Empty, charArrFirst));
                    Console.WriteLine(string.Join(string.Empty, charArrSecond));
                }
                else
                {
                    Console.WriteLine(string.Join(string.Empty, charArrSecond));
                    Console.WriteLine(string.Join(string.Empty, charArrFirst));
                }
            }
            else
            {
                if (charArrFirst.Length < charArrSecond.Length)
                {
                    Console.WriteLine(string.Join(string.Empty, charArrFirst));
                    Console.WriteLine(string.Join(string.Empty, charArrSecond));
                }
                else
                {
                    Console.WriteLine(string.Join(string.Empty, charArrSecond));
                    Console.WriteLine(string.Join(string.Empty, charArrFirst));
                }
            }
        }
    }
}
