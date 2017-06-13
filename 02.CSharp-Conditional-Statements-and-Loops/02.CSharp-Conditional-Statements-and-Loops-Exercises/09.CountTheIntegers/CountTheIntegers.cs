using System;

public class CountTheIntegers
{
    public static void Main()
    {
        int counter = 0;
        bool parsedToInt = true;
        int outValue = 0;

        string input = Console.ReadLine();

        while (parsedToInt)
        {
            parsedToInt = int.TryParse(input, out outValue);

            if (parsedToInt)
            {
                counter++;
            }
            else
            {
                break;
            }

            input = Console.ReadLine();
        }

        Console.WriteLine(counter);
    }
}