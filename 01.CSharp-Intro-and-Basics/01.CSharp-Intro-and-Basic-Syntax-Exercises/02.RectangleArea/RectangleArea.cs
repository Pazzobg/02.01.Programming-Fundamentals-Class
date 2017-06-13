using System;

public class RectangleArea
{
    public static void Main()
    {
        /*Problem 2.	Rectangle Area
         * Write a program, which calculates a rectangle’s area, based on its width and height. 
         * The width and height come as floating point numbers on the console, 
         * formatted to the 2nd character after the decimal point.
         * 
         * 
         * Examples
            Input	Output
            2
            7	    14.00

            7
            8	    56.00
         */

        double width = double.Parse(Console.ReadLine());
        double height = double.Parse(Console.ReadLine());
        Console.WriteLine("{0:f2}", width * height);
    }
}