using System;

public class FiveDifferentNumbers
{
    public static void Main()
    {
        int a = int.Parse(Console.ReadLine());
        int b = int.Parse(Console.ReadLine());
        bool print = false;

        for (int i = a; i <= b; i++)
        {
            for (int j = a; j <= b; j++)
            {
                for (int k = a; k <= b; k++)
                {
                    for (int l = a; l <= b; l++)
                    {
                        for (int m = a; m <= b; m++)
                        {
                            if (m > l && l > k && k > j && j > i)
                            {
                                Console.WriteLine($"{i} {j} {k} {l} {m}");
                                print = true;
                            }
                        }
                    }
                }
            }
        }

        if (!print)
        {
            Console.WriteLine("No");
        }
    }
}