namespace _03.WaterOverflow
{
    using System;

    public class WaterOverflow
    {
        public static void Main()
        {
            byte n = byte.Parse(Console.ReadLine());
            byte currentQuantity = 0;

            for (byte i = 0; i < n; i++)
            {
                short input = short.Parse(Console.ReadLine());

                if (currentQuantity + input > byte.MaxValue)
                {
                    Console.WriteLine("Insufficient capacity!");
                    continue;
                }

                currentQuantity += (byte)input;
            }

            Console.WriteLine(currentQuantity);
        }
    }
}
