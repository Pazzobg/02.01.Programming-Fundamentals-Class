using System;

public class OddNumber
{
    /*Problem 11. Odd Number
    Take as an input an odd number and print the absolute value of it. If the number is even, 
    print "Please write an odd number." and continue reading numbers.
    Input
    You will receive even integers until you receive an odd number.
    Output
    Print "Please write an odd number." if the received number is even. 
    If the number is odd – "The number is: {number}".
    Constraints
    •	You will receive maximum 10 numbers
    •	The numbers will be in the interval [-1000…1000]
     */
    public static void Main()
    {
        int input = int.Parse(Console.ReadLine());

        while (input % 2 == 0)
        {
            Console.WriteLine("Please write an odd number.");

            input = int.Parse(Console.ReadLine());
        }

        Console.WriteLine($"The number is: {Math.Abs(input)}");
    }
}