using System;

public class CaloriesCounter
{
    public static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        int calories = 0;

        for (int i = 0; i < n; i++)
        {
            string input = Console.ReadLine().ToLower();

            switch (input)
            {
                case "cheese": calories += 500; break;
                case "tomato sauce": calories += 150; break;
                case "salami": calories += 600; break;
                case "pepper": calories += 50; break;
            }
        }

        Console.WriteLine($"Total calories: {calories}");
    }
}