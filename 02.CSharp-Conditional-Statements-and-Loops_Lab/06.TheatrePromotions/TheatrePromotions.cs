using System;

public class TheatrePromotions
{
    /*Problem 6. Theatre Promotions
    A theatre is doing a ticket sale, but they need a program to calculate the price of a single ticket. 
    If the given age does not fit one of the categories, you should print "Error!".  
    
    You can see the prices in the table below:
    Day / Age	0<= age <= 18	18 < age <= 16	64 < age <= 122
    Weekday	        12$	             18$	        12$
    Weekend	        15$	             20$	        15$
    Holiday	        5$	             12$	        10$

    Input
    The input comes in two lines. On the first line, you will receive the type of day. On the second – the age of the person.
    
    Output
    Print the price of the ticket according to the table, or "Error!" if the age is not in the table.

    Constraints
    •	The age will be in the interval [-1000…1000].
    •	The type of day will always be valid. 
     */
    public static void Main()
    {
        string dayType = Console.ReadLine();
        int age = int.Parse(Console.ReadLine());
        int price = 0;
        bool youth = age >= 0 && age <= 18;
        bool regular = age > 18 && age <= 64;
        bool senior = age > 64 && age <= 122;

        if (youth || senior)
        {
            switch (dayType)
            {
                case "Weekday": price = 12; break;
                case "Weekend": price = 15; break;
                case "Holiday": price = youth ? 5 : 10; break;
            }
        }
        else if (regular)
        {
            switch (dayType)
            {
                case "Weekday": price = 18; break;
                case "Weekend": price = 20; break;
                case "Holiday": price = 12; break;
            }
        }

        string output = price > 0 ? $"{price}$" : "Error!";
        Console.WriteLine(output);
    }
}
