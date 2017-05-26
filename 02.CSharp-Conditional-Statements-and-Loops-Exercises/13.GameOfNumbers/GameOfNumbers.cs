using System;

public class GameOfNumbers
{
    public static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        int m = int.Parse(Console.ReadLine());
        int magicNumber = int.Parse(Console.ReadLine());
        int counter = 0;
        int lastFoundFirstMember = 0;
        int lastFoundSecondMember = 0;
        bool found = false;

        for (int i = n; i <= m; i++)
        {
            for (int j = n; j <= m; j++)
            {
                counter++;

                if (i + j == magicNumber)
                {
                    lastFoundFirstMember = i;
                    lastFoundSecondMember = j;
                    found = true;
                }
            }
        }

        if (found)
        {
            Console.WriteLine($"Number found! {lastFoundFirstMember} + {lastFoundSecondMember} = {magicNumber}");
        }
        else
        {
            Console.WriteLine($"{counter} combinations - neither equals {magicNumber}");
        }
    }
}