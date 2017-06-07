namespace _11.GeometryCalculator
{
    using System;

    public class GeometryCalculator
    {
        public static void Main()
        {
            string figureType = Console.ReadLine().ToLower();
            double area = 0;

            switch (figureType)
            {
                case "triangle": area = CalculateTriangleArea(); break; 
                case "square": area = CalculateSquareArea(); break;
                case "rectangle": area = CalculateRectangleArea(); break;
                case "circle": area = CalculateCircleArea(); break; 
            }

            Console.WriteLine($"{area:f2}");
        }

        public static double CalculateTriangleArea()
        {
            double side = double.Parse(Console.ReadLine());
            double height = double.Parse(Console.ReadLine());

            return (side * height) / 2;
        }

        public static double CalculateSquareArea()
        {
            double side = double.Parse(Console.ReadLine());

            return side * side;
        }

        public static double CalculateRectangleArea()
        {
            double side = double.Parse(Console.ReadLine());
            double height = double.Parse(Console.ReadLine());

            return side * height;
        }

        public static double CalculateCircleArea()
        {
            double radius = double.Parse(Console.ReadLine());

            return Math.PI * radius * radius;
        }
    }
}
