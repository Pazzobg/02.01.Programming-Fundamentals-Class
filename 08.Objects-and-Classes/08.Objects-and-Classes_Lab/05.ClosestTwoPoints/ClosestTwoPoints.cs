namespace _05.ClosestTwoPoints
{
    using System;

    public class ClosestTwoPoints
    {
        public static void Main()
        {
            int n = int.Parse(Console.ReadLine());

            Point[] pointsArr = new Point[n];

            for (int i = 0; i < n; i++)
            {
                string[] currentPointCoordinates = Console.ReadLine().Split(' ');

                var currentPoint = new Point
                {
                    X = int.Parse(currentPointCoordinates[0]),
                    Y = int.Parse(currentPointCoordinates[1])
                };

                pointsArr[i] = currentPoint;
            }

            FindClosestPointsPair(pointsArr);
        }

        public static void FindClosestPointsPair(Point[] pointsArr)
        {
            var closestDistance = double.MaxValue;
            Point[] closestPair = new Point[2];

            for (int i = 0; i < pointsArr.Length - 1; i++)
            {
                for (int j = i + 1; j < pointsArr.Length; j++)
                {
                    double currentDistance = CalculateDistanceBetweenPoints(pointsArr[i], pointsArr[j]);

                    if (currentDistance < closestDistance)
                    {
                        closestDistance = currentDistance;
                        closestPair[0] = pointsArr[i];
                        closestPair[1] = pointsArr[j];
                    }
                }
            }

            PrintResult(closestDistance, closestPair);
        }

        public static double CalculateDistanceBetweenPoints(Point firstPoint, Point secondPoint)
        {
            int diffX = firstPoint.X - secondPoint.X;
            int diffY = firstPoint.Y - secondPoint.Y;
            double powX = Math.Pow(diffX, 2);
            double powY = Math.Pow(diffY, 2);

            return Math.Sqrt(powX + powY);
        }

        public static void PrintResult(double closestDistance, Point[] closestPair)
        {
            Console.WriteLine($"{closestDistance:f3}");
            Console.WriteLine($"({closestPair[0].X}, {closestPair[0].Y})");
            Console.WriteLine($"({closestPair[1].X}, {closestPair[1].Y})");
        }
    }
}
