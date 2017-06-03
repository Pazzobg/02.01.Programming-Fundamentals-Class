namespace _06.CatchTheThief
{
    using System;

    public class CatchTheThief
    {
        public static void Main()
        {
            string type = Console.ReadLine();
            byte n = byte.Parse(Console.ReadLine());
            long maxLimit = 0;

            switch (type)
            {
                case "sbyte": maxLimit = sbyte.MaxValue;break;
                case "int": maxLimit = int.MaxValue;break;
                case "long": maxLimit = long.MaxValue;break;
            }

            ulong smallestDiff = ulong.MaxValue;
            long foundId = 0;

            for (byte i = 0; i < n; i++)
            {
                long input = long.Parse(Console.ReadLine());
                ulong currentDiff = (ulong)(maxLimit - input);
                if ((currentDiff < smallestDiff) && currentDiff >= 0)
                {
                    smallestDiff = currentDiff;
                    foundId = input;
                }
            }

            Console.WriteLine(foundId);
        }
    }
}
