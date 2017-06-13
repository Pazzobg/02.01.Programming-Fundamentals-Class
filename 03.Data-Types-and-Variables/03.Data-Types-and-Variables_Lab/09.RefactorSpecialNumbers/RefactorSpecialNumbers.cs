namespace _09.RefactorSpecialNumbers
{
    using System;

    public class RefactorSpecialNumbers
    {
        public static void Main()
        {
            int n = int.Parse(Console.ReadLine());
            bool special = false;

            for (int i = 1; i <= n; i++)
            {
                int sumCurrentNumber = 0;
                int number = i;

                while (number > 0)
                {
                    sumCurrentNumber += number % 10;
                    number /= 10;
                }

                special = (sumCurrentNumber == 5) || (sumCurrentNumber == 7) || (sumCurrentNumber == 11);
                Console.WriteLine($"{i} -> {special}");
            }
        }
    }
}