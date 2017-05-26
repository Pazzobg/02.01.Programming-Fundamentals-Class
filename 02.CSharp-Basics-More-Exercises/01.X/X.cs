using System;

public class X
{
    public static void Main()
    {
        int n = int.Parse(Console.ReadLine());

        int loopEnd = n / 2;
        int spaceOut = 0;
        int spaceIn = n - 2;

        for (int i = 0; i < loopEnd; i++)
        {
            Console.WriteLine("{0}x{1}x", new string(' ', spaceOut), new string(' ', spaceIn));

            spaceOut++;
            spaceIn -= 2;
        }

        Console.WriteLine($"{new string(' ', spaceOut)}x");

        for (int i = 0; i < loopEnd; i++)
        {
            spaceOut--;
            spaceIn += 2;

            Console.WriteLine("{0}x{1}x", new string(' ', spaceOut), new string(' ', spaceIn));
        }
    }
}