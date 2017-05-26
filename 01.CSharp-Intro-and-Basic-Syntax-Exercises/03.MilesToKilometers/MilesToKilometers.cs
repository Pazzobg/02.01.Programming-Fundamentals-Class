using System;

public class MilesToKilometers
{
    public static void Main()
    {
        /*Problem 3.Miles to Kilometers
         * Write a program, which converts miles to kilometers.Format the output to the 2nd decimal place.
         * Note: 1 mile == 1.60934 kilometers
         *
         * Examples
           Input	Output		Input	Output		Input	Output
           60	    96.56		1	    1.61		52.1113	83.86
         */

        double miles = double.Parse(Console.ReadLine());
        Console.WriteLine("{0:f2}", miles * 1.60934);
    }
}
