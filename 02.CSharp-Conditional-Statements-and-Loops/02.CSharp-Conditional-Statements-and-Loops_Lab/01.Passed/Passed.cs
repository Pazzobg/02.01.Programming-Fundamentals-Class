using System;

public class Passed
{
    public static void Main()
    {
        /*Problem 1. Passed
        Write a program, which takes as an input a grade and prints “Passed!” if the grade is equal or more than 3.00.
        Input
        The input comes as a single floating-point number.
        Output
        The output is either "Passed!" if the grade is equal or more than 3.00, otherwise you should print nothing.
         */

        double grade = double.Parse(Console.ReadLine());

        if (grade >= 3)
        {
            Console.WriteLine("Passed!");
        }
    }
}

