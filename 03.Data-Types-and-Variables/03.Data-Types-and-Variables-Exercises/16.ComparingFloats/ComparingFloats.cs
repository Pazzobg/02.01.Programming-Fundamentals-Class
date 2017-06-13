namespace _16.ComparingFloats
{
    using System;

    public class ComparingFloats
    {
        public static void Main()
        {
            double eps = 0.000001;
            double num1 = double.Parse(Console.ReadLine());
            double num2 = double.Parse(Console.ReadLine());

            bool equal = false;

            if (Math.Abs(num1 - num2) < eps)
            {
                equal = true;
            }

            Console.WriteLine(equal);
        }
    }
}
