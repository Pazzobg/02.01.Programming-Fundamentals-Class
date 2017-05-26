using System;

public class Program
{
    /*Problem 10. Multiplication Table 2.0
    Rewrite you program so it can receive the multiplier from the console. 
    Print the table from the given multiplier to 10. If the given multiplier is 
    more than 10 - print only one row with the integer, the given multiplier and the product. 
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
        int i = int.Parse(Console.ReadLine());

        if (i <= 10)
        {
            for (; i <= 10; i++)
            {
                Console.WriteLine($"{n} X {i} = {n * i}");
            }
        }
        else
        {
            Console.WriteLine($"{n} X {i} = {n * i}");
        }
    }
}