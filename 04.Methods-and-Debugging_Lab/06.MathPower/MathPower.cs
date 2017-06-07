namespace _06.MathPower
{
    using System;

    public class MathPower
    {
        public static void Main()
        {
            double number = double.Parse(Console.ReadLine());
            double power = double.Parse(Console.ReadLine());

            Console.WriteLine(CalculatePowerOfNumber(number, power));
        }

        public static double CalculatePowerOfNumber(double number, double power)
        {
            double result = number;

            for (double i = 1; i < power; i++)
            {
                result *= number;
            }

            return result;
        }
    }
}
