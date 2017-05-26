using System;

public class DebitCardNumber
{
    public static void Main()
    {
        /* Problem 1.	Debit Card Number
         * Write a program, which receives 4 integers on the console and prints them in 4-digit 
         * debit card format. See the examples below for the appropriate formatting. 
         * 
         * Input	Output
         *  12
         *  433
         *  1
         *  5331	0012 0433 0001 5331
         */

        int firstSet = int.Parse(Console.ReadLine());
        int secondSet = int.Parse(Console.ReadLine());
        int thirdSet = int.Parse(Console.ReadLine());
        int fourthSet = int.Parse(Console.ReadLine());

        Console.WriteLine($"{firstSet:d4} {secondSet:d4} {thirdSet:d4} {fourthSet:d4}");
    }
}
