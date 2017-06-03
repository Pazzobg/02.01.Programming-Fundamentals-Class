namespace _12.BeerKings
{
    using System;

    public class BeerKings
    {
        public static void Main()
        {
            int n = int.Parse(Console.ReadLine());

            double biggestVolume = 0;
            string biggestModel = string.Empty;

            for (int i = 0; i < n; i++)
            {
                string kegModel = Console.ReadLine();
                float radius = float.Parse(Console.ReadLine());
                int height = int.Parse(Console.ReadLine());

                double currentVolume = Math.PI * Math.Pow(radius, 2) * height;

                if (currentVolume > biggestVolume)
                {
                    biggestVolume = currentVolume;
                    biggestModel = kegModel;
                }
            }

            Console.WriteLine(biggestModel);
        }
    }
}
