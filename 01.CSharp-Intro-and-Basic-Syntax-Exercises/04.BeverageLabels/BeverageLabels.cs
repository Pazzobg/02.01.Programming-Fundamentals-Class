using System;

public class BeverageLabels
{
    public static void Main()
    {
        /* Problem 4.	Beverage Labels
         * Write a program, which reads a food product name, volume, energy content per 100ml 
         * and sugar content per 100ml. Calculate the energy and sugar content for 
         * the given volume and print them on the console in the following format:
         * 
            •	Name – as per the input
            •	Volume – integer, suffixed by “ml” (e.g. “220ml”)
            •	Energy content – integer, suffixed by “kcal” (e.g. “500kcal”)
            •	Sugar content – integer, suffixed by “g” (e.g. “30g”) 
            Examples
            Input	Output
            Nuka-Cola
            220
            300
            70	220ml Nuka-Cola:
            660kcal, 154g sugars
         * */

        string name = Console.ReadLine();
        double volume = double.Parse(Console.ReadLine());
        double kcalPerHundred = double.Parse(Console.ReadLine());
        double sugarPerHundred = double.Parse(Console.ReadLine());
        double multiplier = volume / 100;

        Console.WriteLine($"{volume}ml {name}:\n{kcalPerHundred * multiplier}kcal, {sugarPerHundred * multiplier}g sugars");
    }
}