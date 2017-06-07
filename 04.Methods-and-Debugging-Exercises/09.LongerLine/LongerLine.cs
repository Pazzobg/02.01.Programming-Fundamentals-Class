namespace _09.LongerLine
{
    using System;

    public class LongerLine
    {
        public static void Main()
        {
            double x1 = double.Parse(Console.ReadLine());
            double y1 = double.Parse(Console.ReadLine());
            double x2 = double.Parse(Console.ReadLine());
            double y2 = double.Parse(Console.ReadLine());
            double a1 = double.Parse(Console.ReadLine());
            double b1 = double.Parse(Console.ReadLine());
            double a2 = double.Parse(Console.ReadLine());
            double b2 = double.Parse(Console.ReadLine());

            CalculateTheLongerLine(x1, y1, x2, y2, a1, b1, a2, b2);
        }

        public static void CalculateTheLongerLine(
            double x1, double y1, double x2, double y2, double a1, double b1, double a2, double b2)
        {
            double line1 = Math.Abs(x1) + Math.Abs(y1) - Math.Abs(x2) + Math.Abs(y2);
            double line2 = Math.Abs(a1) + Math.Abs(b1) - Math.Abs(a2) + Math.Abs(b2);

            if (line1 >= line2)
            {
                DeterminePointCloserToCenter(x1, y1, x2, y2);
            }
            else
            {
                DeterminePointCloserToCenter(a1, b1, a2, b2);
            }
        }

        public static void DeterminePointCloserToCenter(double n1, double m1, double n2, double m2)
        {
            double sumPoint1 = Math.Abs(n1) + Math.Abs(m1);
            double sumPoint2 = Math.Abs(n2) + Math.Abs(m2);

            Console.WriteLine(sumPoint2 < sumPoint1 ? $"({n2}, {m2})({n1}, {m1})" : $"({n1}, {m1})({n2}, {m2})");
        }
    }
}
