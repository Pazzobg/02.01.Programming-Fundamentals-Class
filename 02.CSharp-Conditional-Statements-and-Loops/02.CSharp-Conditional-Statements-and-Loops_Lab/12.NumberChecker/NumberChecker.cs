using System;

public class NumberChecker
{
    /*Problem 12. Number checker
    Write a program, which reads an input from the console and prints "It is a number." if it’s a number. 
    If it is not write "Invalid input!"
    Input
    You will receive a single line of input.
    Output
    Print one of the messages, but without throwing an exception.
    Examples
    Input	    Output		        Input	Output
    5	        It is a number.		five	Invalid input!
    Hints
    You can use a try-catch block to prevent throwing an exception.
     */
    public static void Main()
    {
        try
        {
        int input = int.Parse(Console.ReadLine());
        Console.WriteLine("It is a number.");
        }
        catch (Exception)
        {
            Console.WriteLine("Invalid input!");
        }
    }
}