namespace _06.RectanglePosition
{
    using System;

    public class RectanglePosition
    {
        public static void Main()
        {
            Rectangle firstRectangle = ReadRectangle();
            Rectangle secondRectangle = ReadRectangle();

            bool inside = CheckIfFirstInsideSecond(firstRectangle, secondRectangle);

            Console.WriteLine(inside ? "Inside" : "Not inside");
        }

        private static Rectangle ReadRectangle()
        {
            string[] rectangleProperties = Console.ReadLine().Split(' ');

            var rectangle = new Rectangle
            {
                Left = int.Parse(rectangleProperties[0]),
                Top = int.Parse(rectangleProperties[1]),
                Width = int.Parse(rectangleProperties[2]),
                Height = int.Parse(rectangleProperties[3])
            };

            return rectangle;
        }

        public static bool CheckIfFirstInsideSecond(Rectangle firstRectangle, Rectangle secondRectangle)
        {
            bool leftIsInside = firstRectangle.Left >= secondRectangle.Left;
            bool rightIsInside = firstRectangle.Right <= secondRectangle.Right;
            bool topIsInside = firstRectangle.Top <= secondRectangle.Top;
            bool bottomIsInside = firstRectangle.Bottom >= secondRectangle.Bottom;

            return leftIsInside && rightIsInside && topIsInside && bottomIsInside;
        }
    }
}
