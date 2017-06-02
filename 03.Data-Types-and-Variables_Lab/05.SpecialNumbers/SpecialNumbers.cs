namespace _05.SpecialNumbers
{
    using System;
    using System.Linq;

    public class SpecialNumbers
    {
        public static void Main()
        {
            int number = int.Parse(Console.ReadLine());

            for (int i = 1; i <= number; i++)
            {
                int sumOfDigits = i.ToString().Sum(n => n - '0');
                bool special = false;

                switch (sumOfDigits)
                {
                    case 5:
                    case 7:
                    case 11: special = true; break;
                }

                Console.WriteLine($"{i} -> {special}");
            }
        }
    }
}