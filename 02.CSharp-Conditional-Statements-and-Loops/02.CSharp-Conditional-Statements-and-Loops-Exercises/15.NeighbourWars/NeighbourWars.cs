using System;

public class NeighbourWars
{
    public static void Main()
    {
        int peshoHealth = 100;
        int goshoHealth = 100;

        int peshoDoesDamage = int.Parse(Console.ReadLine());
        int goshoDoesDamage = int.Parse(Console.ReadLine());

        int round = 0;

        while (true)
        {
            round++;

            if (round % 2 != 0)         //Pesho's attacks
            {
                goshoHealth -= peshoDoesDamage;
                if (goshoHealth <= 0) break;
                Console.WriteLine($"Pesho used Roundhouse kick and reduced Gosho to {goshoHealth} health.");
            }
            else                        //Gosho's attacks
            {
                peshoHealth -= goshoDoesDamage;
                if (peshoHealth <= 0) break;
                Console.WriteLine($"Gosho used Thunderous fist and reduced Pesho to {peshoHealth} health.");
            }

            if (round % 3 == 0)         // Energy boost every third round
            {
                peshoHealth += 10;
                goshoHealth += 10;
            }
        }

        if (peshoHealth > 0)
        {
            Console.WriteLine($"Pesho won in {round}th round.");
        }
        else
        {
            Console.WriteLine($"Gosho won in {round}th round.");
        }
    }
}