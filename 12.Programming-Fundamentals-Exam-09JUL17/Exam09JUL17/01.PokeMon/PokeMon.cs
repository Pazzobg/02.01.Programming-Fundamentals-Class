namespace _01.PokeMon
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    public class PokeMon
    {
        public static void Main()
        {
            int pokePower = int.Parse(Console.ReadLine());
            int distanceBetweenTargets = int.Parse(Console.ReadLine());
            int exhaustionFactor = int.Parse(Console.ReadLine());
            int count = 0;

            decimal halfPower = pokePower * 0.5m;

            while (pokePower >= distanceBetweenTargets)
            {
                pokePower -= distanceBetweenTargets;
                count++;

                if (pokePower == halfPower && exhaustionFactor > 0)
                {
                    pokePower /= exhaustionFactor;
                }
            }

            Console.WriteLine(pokePower);
            Console.WriteLine(count);
        }
    }
}
