using System;

public class MagicLetter
{
    public static void Main()
    {
        char start = char.Parse(Console.ReadLine());
        char end = char.Parse(Console.ReadLine());
        char letterToAvoid = char.Parse(Console.ReadLine());

        for (char i = start; i <= end; i++)
        {
            if (i == letterToAvoid) continue;

            for (char j = start; j <= end; j++)
            {
                if (j == letterToAvoid) continue;

                for (char k = start; k <= end; k++)
                {
                    if (k == letterToAvoid) continue;

                    Console.Write($"{i}{j}{k} ");
                }
            }
        }

        Console.WriteLine();
    }
}