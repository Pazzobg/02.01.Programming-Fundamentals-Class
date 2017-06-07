namespace _05.CalculateTriangleArea
{
    using System;

    public class CalculateTriangleArea
    {
        public static void Main()
        {
            double side = double.Parse(Console.ReadLine());
            double heightSide = double.Parse(Console.ReadLine());

            Console.WriteLine(CalculateArea(side, heightSide));
        }

        public static double CalculateArea(double side, double heightSide)
        {
            double area = (side * heightSide) / 2;
            return area;
        }
    }
}
