using System;

public class DivisibleBy3
{
    /*Write a program, which prints all the numbers from 1 to 100, which are divisible by 3. 
     * You have to use a single for loop. The program should not receive input.
     */
    public static void Main()
    {
        for (int i = 1; i <= 100; i++)
        {
            if (i % 3 == 0)
            {
                Console.WriteLine(i);
            }
        }

        // Performance of the above solution is way better than: 
        //for (int i = 3; i <= 100; i += 3)
        //{
        //    Console.WriteLine(i);
        //}
        // this one needs 7.34MB according to SU Judge, and the first one 0.11 - 0.07MB.

    }
}
