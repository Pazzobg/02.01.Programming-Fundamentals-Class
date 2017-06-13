using System;

public class TestNumbers
{
    public static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        int m = int.Parse(Console.ReadLine());
        int maxSumLimit = int.Parse(Console.ReadLine());

        int sum = 0;
        int counter = 0;
        bool limitExceeded = false;

        for (int i = n; i >= 1; i--)
        {
            for (int j = 1; j <= m; j++)
            {
                sum += (i * j) * 3;
                counter++;

                if (sum >= maxSumLimit)
                {
                    limitExceeded = true;
                    break;
                }
            }

            if (sum >= maxSumLimit) break;
        }

        if (limitExceeded)
        {
            Console.WriteLine($"{counter} combinations");
            Console.WriteLine($"Sum: {sum} >= {maxSumLimit}");
        }
        else
        {
            Console.WriteLine($"{counter} combinations");
            Console.WriteLine($"Sum: {sum}");
        }
    }
}