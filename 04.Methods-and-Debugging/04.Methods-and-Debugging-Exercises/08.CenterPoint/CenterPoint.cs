namespace _08.CenterPoint
{
    using System;

    public class CenterPoint
    {
        static void Main()
        {
            double x1 = double.Parse(Console.ReadLine());
            double y1 = double.Parse(Console.ReadLine());
            double x2 = double.Parse(Console.ReadLine());
            double y2 = double.Parse(Console.ReadLine());

            string output = FindClosestPoint(x1, y1, x2, y2);
            Console.WriteLine(output);
        }

        public static string FindClosestPoint(double x1, double y1, double x2, double y2)
        {
            double sumPoint1 = Math.Abs(x1) + Math.Abs(y1);
            double sumPoint2 = Math.Abs(x2) + Math.Abs(y2);

            string output = sumPoint2 < sumPoint1 ? $"({x2}, {y2})" : $"({x1}, {y1})";
            return output;
        }
    }
}
