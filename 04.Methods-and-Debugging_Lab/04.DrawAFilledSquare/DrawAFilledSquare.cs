namespace _04.DrawAFilledSquare
{
    using System;

    public class DrawAFilledSquare
    {
        public static void Main()
        {
            int n = int.Parse(Console.ReadLine());
            int sideLength = n * 2;
            int body = n - 2;

            DrawTopBottom(sideLength);
            DrawBody(n, body);
            DrawTopBottom(sideLength);
        }

        public static void DrawBody(int n, int body)
        {
            for (int i = 0; i < body; i++)
            {
                Console.Write('-');

                for (int j = 0; j < n - 1; j++)
                {
                    Console.Write("\\/");
                }

                Console.WriteLine('-');
            }
        }

        public static void DrawTopBottom(int sideLength)
        {
            Console.WriteLine(new string('-', sideLength));
        }
    }
}
