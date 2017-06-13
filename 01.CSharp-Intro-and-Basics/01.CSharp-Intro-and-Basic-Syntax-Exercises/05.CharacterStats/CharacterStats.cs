using System;

public class CharacterStats
{
    public static void Main()
    {
        /*Character Stats
        Write a program, which displays information about a video game character. 
        You will receive their name, current health, maximum health, current energy and 
        maximum energy on separate lines. The current values will always be valid (equal or lower 
        than their respective max values). Print them in the format as per the examples.
        Examples
        Input	        Output		                Input	    Output
        Mayro           Name: Mayro                 Bauser      Name: Bauser
        5               Health: ||||||.....|        10          Health: ||||||||||||
        10              Energy: ||||||||||.|        10          Energy: ||||||||||||
        9                                           10
        10	                                        10
         */

        string name = Console.ReadLine();
        int currHealth = int.Parse(Console.ReadLine());
        int maxHealth = int.Parse(Console.ReadLine());
        int currEnergy = int.Parse(Console.ReadLine());
        int maxEnergy = int.Parse(Console.ReadLine());

        int emptyHealth = maxHealth - currHealth;
        int emptyEnergy = maxEnergy - currEnergy;

        Console.WriteLine($"Name: {name}");
        Console.WriteLine($"Health: |{new string('|', currHealth)}{new string('.', emptyHealth)}|");
        Console.WriteLine($"Energy: |{new string('|', currEnergy)}{new string('.', emptyEnergy)}|");
    }
}
