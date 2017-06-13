namespace _10.CubeProperties
{
    using System;

    public class CubeProperties
    {
        public static void Main()
        {
            double side = double.Parse(Console.ReadLine());
            string parameter = Console.ReadLine();
            double output = 0;
            switch (parameter)
            {
                case "face": output = CalculateFaceDiagonal(side); break;
                case "space": output = CalculateSpaceDiagonal(side); break;
                case "volume": output = CalculateVolume(side); break;
                case "area": output = CalculateSurfaceArea(side); break;
            }

            Console.WriteLine($"{output:f2}");
        }

        public static double CalculateFaceDiagonal(double side)
        {
            double faceDiag = Math.Sqrt(2 * Math.Pow(side, 2));
            return faceDiag;
        }

        public static double CalculateSpaceDiagonal(double side)
        {
            double spaceDiag = Math.Sqrt(3 * Math.Pow(side, 2));
            return spaceDiag;
        }

        public static double CalculateVolume(double side)
        {
            double volume = Math.Pow(side, 3);
            return volume;
        }

        public static double CalculateSurfaceArea(double side)
        {
            double area = 6 * Math.Pow(side, 2);
            return area;
        }
    }
}
