namespace _03.HornetAssault
{
    using System;
    using System.Linq;

    public class HornetAssault
    {
        public static void Main()
        {
            var beehives = Console.ReadLine()
                .Split(new[] { ' ', '\t' }, StringSplitOptions.RemoveEmptyEntries)
                .Select(long.Parse)
                .ToList();

            var hornets = Console.ReadLine()
                .Split(new[] { ' ', '\t' }, StringSplitOptions.RemoveEmptyEntries)
                .Select(long.Parse)
                .ToList();

            for (int i = 0; i < beehives.Count; i++)
            {
                long hornetsPower = hornets.Sum();

                if (hornetsPower > beehives[i])
                {
                    beehives[i] = 0;
                }
                else
                {
                    beehives[i] -= hornetsPower;
                    hornets.RemoveAt(0);
                }

                if (hornets.Count == 0)
                {
                    break;
                }
            }

            if (beehives.Any(x => x > 0))
            {
                Console.WriteLine(string.Join(" ", beehives.Where(x => x > 0)));
            }
            else
            {
                Console.WriteLine(string.Join(" ", hornets));
            }
        }
    }
}
