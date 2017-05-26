using System;

public class IntervalOfNumbers
{
    public static void Main()
    {
        int numOne = int.Parse(Console.ReadLine());
        int numTwo = int.Parse(Console.ReadLine());

        int start = Math.Min(numOne, numTwo);
        int end = Math.Max(numOne, numTwo);

        for (int i = start; i <= end; i++)
        {
            Console.WriteLine(i);
        }
    }
}