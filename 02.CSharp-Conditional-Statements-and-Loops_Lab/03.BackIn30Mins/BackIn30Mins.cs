using System;

public class BackIn30Mins
{
    public static void Main()
    {
        /*Problem 3. Back in 30 Minutes
        Every time Stamat tries to pay his bills he sees on the cash desk the sign: "I will be back in 30 minutes". 
        One day Stamat was sick of waiting and decided he needs a program, which prints the time after 30 minutes. 
        That way he won’t have to wait on the desk and come at the appropriate time. 
        He gave the assignment to you, so you have to do it. 
        Input
        The input will be on two lines. On the first line, you will receive the hours and 
        on the second you will receive the minutes. 
        Output
        Print on the console the time after 30 minutes. The result should be in format hh:mm. 
        The hours have one or two numbers and the minutes have always two numbers (with leading zero).
        Constraints
        •	The hours will be between 0 and 23.
        •	The minutes will be between 0 and 59.
         */

        int hours = int.Parse(Console.ReadLine());
        int minutes = int.Parse(Console.ReadLine());
        int totalTime = ((hours * 60) + minutes) + 30;

        int hoursInThirtyMins = totalTime / 60;
        int minutesInThirtyMins = totalTime % 60;

        if (hoursInThirtyMins > 23)
        {
            hoursInThirtyMins = 0;
        }

        Console.WriteLine($"{hoursInThirtyMins}:{minutesInThirtyMins:d2}");
    }
}