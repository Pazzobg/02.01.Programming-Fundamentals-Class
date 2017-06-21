namespace _03.CirclesIntersection
{
    using System;
    using System.Linq;

    public class CirclesIntersection
    {
        public static void Main()
        {
            double[] circleOneData = Console.ReadLine().Split(' ').Select(double.Parse).ToArray();
            double[] circleTwoData = Console.ReadLine().Split(' ').Select(double.Parse).ToArray();

            Circle firstCircle = new Circle
            {
                X = circleOneData[0],
                Y = circleOneData[1],
                Radius = circleOneData[2]
            };

            Circle secondCircle = new Circle
            {
                X = circleTwoData[0],
                Y = circleTwoData[1],
                Radius = circleTwoData[2]
            };

            bool bothCirclesIntersect = Intersect(firstCircle, secondCircle);

            Console.WriteLine(bothCirclesIntersect ? "Yes" : "No");
        }

        // As per rule, if the distance between the centers of two circles is less or equal of 
        // the sum of their radii, the two circles overlap - they could either touch in a single point
        // or partially overlap, or one is completely inside the other. 
        // If the distance between the centers is greater than the sum of the radii, 
        // both circles do NOT overlap / intersect. 

        public static bool Intersect(Circle firstCircle, Circle secondCircle)
        {
            double distance = CalculateDistance(firstCircle, secondCircle);
            double sumOfRadiuses = firstCircle.Radius + secondCircle.Radius;

            return distance <= sumOfRadiuses ? true : false;
        }

        // Calculating the distance between the centers of both circles
        public static double CalculateDistance(Circle firstCircle, Circle secondCircle)
        {
            double sideOne = firstCircle.X - secondCircle.X;
            double sideTwo = firstCircle.Y - secondCircle.Y;

            double distance = Math.Sqrt(Math.Pow(sideOne, 2) + Math.Pow(sideTwo, 2));

            return distance;
        }
    }
}
