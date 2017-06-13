namespace _08.HouseBuilder
{
    using System;

    public class HouseBuilder
    {
        public static void Main()
        {
            long inputOne = long.Parse(Console.ReadLine());
            long inputTwo = long.Parse(Console.ReadLine());

            long totalPrice = 0;

            if (inputOne < inputTwo)
            {
                totalPrice = (inputOne * 4) + (inputTwo * 10);
            }
            else
            {
                totalPrice = (inputOne * 10) + (inputTwo * 4);
            }

            Console.WriteLine(totalPrice);
        }
    }
}
