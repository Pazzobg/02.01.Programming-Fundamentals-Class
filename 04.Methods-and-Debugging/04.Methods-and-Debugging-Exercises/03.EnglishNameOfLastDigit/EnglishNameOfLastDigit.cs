namespace _03.EnglishNameOfLastDigit
{
    using System;

    public class EnglishNameOfLastDigit
    {
        public static void Main()
        {
            long number = long.Parse(Console.ReadLine());

            PrintNameOfLastDigit(Math.Abs(number % 10));
        }

        public static void PrintNameOfLastDigit(long num)
        {
            string name = string.Empty;

            switch (num)
            {
                case 1: name = "one"; break;
                case 2: name = "two"; break;
                case 3: name = "three"; break;
                case 4: name = "four"; break;
                case 5: name = "five"; break;
                case 6: name = "six"; break;
                case 7: name = "seven"; break;
                case 8: name = "eight"; break;
                case 9: name = "nine"; break;
                default: name = "zero"; break;
            }

            Console.WriteLine(name);
        }
    }
}
