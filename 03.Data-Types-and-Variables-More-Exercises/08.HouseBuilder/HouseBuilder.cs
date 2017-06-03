namespace _08.HouseBuilder
{
    using System;

    public class HouseBuilder
    {
        public static void Main()
        {
            int inputOne = int.Parse(Console.ReadLine());
            int inputTwo = int.Parse(Console.ReadLine());

            long totalPrice = 0;

            if (inputOne < inputTwo)
            {
                totalPrice = ((long)inputOne * 4) + ((long)inputTwo * 10);
            }
            else
            {
                totalPrice = ((long)inputOne * 10) + ((long)inputTwo * 4);
            }

            Console.WriteLine(totalPrice);
        }
    }
}
