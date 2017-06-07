namespace _02.MaxMethod
{
    using System;

    public class MaxMethod
    {
        public static void Main()
        {
            int num1 = int.Parse(Console.ReadLine());
            int num2 = int.Parse(Console.ReadLine());
            int num3 = int.Parse(Console.ReadLine());
            
            GetMax(num1, num2, num3);
        }

        /// <summary>
        /// Returns the biggest of three integers after comparisson.
        /// </summary>
        /// <param name="num1"></param>
        /// <param name="num2"></param>
        /// <param name="num3"></param>
        public static void GetMax(int num1, int num2, int num3)
        {
            int max = num1 > num2 ? num1 : num2;
            max = max > num3 ? max : num3;

            Console.WriteLine(max);
        }

        /// <summary>
        /// Returns the bigger of two integers after comparisson.
        /// </summary>
        /// <param name="num1"></param>
        /// <param name="num2"></param>
        private static void GetMax(int num1, int num2)
        {
            int max = num1 > num2 ? num1 : num2;

            Console.WriteLine(max);
        }
    }
}
