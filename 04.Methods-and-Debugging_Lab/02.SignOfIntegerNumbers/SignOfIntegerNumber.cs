namespace _02.SignOfIntegerNumbers
{
    using System;

    public class SignOfIntegerNumber
    {
        public static void Main()
        {
            int n = int.Parse(Console.ReadLine());

            PrintMessage(n);
        }

        public static void PrintMessage(int n)
        {
            if (n < 0)
            {
                Console.WriteLine($"The number {n} is negative.");
            }
            else if (n > 0)
            {
                Console.WriteLine($"The number {n} is positive.");
            }
            else
            {
                Console.WriteLine("The number 0 is zero.");
            }
        }
    }
}
