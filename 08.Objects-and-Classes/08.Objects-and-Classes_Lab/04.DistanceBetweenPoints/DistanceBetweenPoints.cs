namespace _04.DistanceBetweenPoints
{
    using System;

    public class DistanceBetweenPoints
    {
        public static void Main()
        {
            string[] firstPointInfo = Console.ReadLine().Split(' ');
            string[] secondPointInfo = Console.ReadLine().Split(' ');

            var firstPoint = new Point
            {
                X = int.Parse(firstPointInfo[0]),
                Y = int.Parse(firstPointInfo[1])
            };
            var secondPoint = new Point
            {
                X = int.Parse(secondPointInfo[0]),
                Y = int.Parse(secondPointInfo[1])
            };

            double distance = CalculateDistanceBetweenPoints(firstPoint, secondPoint);

            Console.WriteLine($"{distance:f3}");
        }

        public static double CalculateDistanceBetweenPoints(Point firstPoint, Point secondPoint)
        {
            int diffX = firstPoint.X - secondPoint.X;
            int diffY = firstPoint.Y - secondPoint.Y;
            double powX = Math.Pow(diffX, 2);
            double powY = Math.Pow(diffY, 2);

            return Math.Sqrt(powX + powY);
        }
    }
}