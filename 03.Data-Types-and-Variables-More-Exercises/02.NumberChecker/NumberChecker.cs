namespace _02.NumberChecker
{
    using System;
    public class NumberChecker
    {
        public static void Main()
        {
            string input = Console.ReadLine();

            long outNum = 0;

            bool successfullyPased = long.TryParse(input, out outNum);

            if (successfullyPased)
            {
                Console.WriteLine("integer");
            }
            else
            {
                Console.WriteLine("floating-point");
            }

            //if (input.Contains("."))
            //{
            //    Console.WriteLine("floating-point");
            //}
            //else
            //{
            //    Console.WriteLine("integer");
            //}
        }
    }
}
