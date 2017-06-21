using System;

namespace _03.CirclesIntersection
{
    public class Circle
    {
        public double X { get; set; }

        public double Y { get; set; }

        public double Radius { get; set; }

        public double Center { get; set; }

        public double Area => Math.PI * Radius * Radius;

        public double Perimeter => 2 * Math.PI * Radius;
    }
}