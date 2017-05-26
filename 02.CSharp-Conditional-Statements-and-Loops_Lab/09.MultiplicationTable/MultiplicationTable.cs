using System;

public class MultiplicationTable
{
    /*Problem 9. Multiplication Table
    You will receive an integer as an input from the console. Print the 10 times table for this integer. 
    See the examples below for more information.
    Output
    Print every row of the table in the following format:
    {theInteger} X {times} = {product}
    Constraints
    •	The integer will be in the interval [1…100]
     */
    public static void Main()
    {
        int n = int.Parse(Console.ReadLine());

        for (int i = 1; i <= 10; i++)
        {
            Console.WriteLine($"{n} X {i} = {n * i}");
        }
    }
}
