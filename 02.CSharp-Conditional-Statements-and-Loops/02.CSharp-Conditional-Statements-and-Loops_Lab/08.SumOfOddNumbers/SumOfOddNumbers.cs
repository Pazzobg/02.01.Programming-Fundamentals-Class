using System;

public class SumOfOddNumbers
{
    /*Problem 8. Sum of Odd Numbers
    Write a program that prints the next n odd numbers (starting from 1) and on the last row prints the sum of them.
    Input
    On the first line, you will receive a number – n. This number shows how many odd numbers you should print.
    Output
    Print the next n odd numbers, starting from 1, separated by new lines. On the last line, print the sum of these numbers.
    Constraints
    •	n will be in the interval [1…100]
     */
    public static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        int sum = 0;

        for (int i = 1; i <= n; i++)
        {
            int currentNumber = (2 * i) - 1;
            Console.WriteLine(currentNumber);
            sum += currentNumber;
        }

        Console.WriteLine($"Sum: {sum}");
    }
}
