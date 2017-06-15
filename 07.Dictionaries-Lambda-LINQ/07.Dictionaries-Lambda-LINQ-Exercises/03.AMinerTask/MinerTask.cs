namespace _03.AMinerTask
{
    using System;
    using System.Collections.Generic;

    public class MinerTask
    {
        public static void Main()
        {
            var resources = new Dictionary<string, long>();

            while (true)
            {
                string item = Console.ReadLine();
                if (item == "stop") break;

                int quantity = int.Parse(Console.ReadLine());

                if (!resources.ContainsKey(item))
                {
                    resources[item] = 0;
                }

                resources[item] += quantity;
            }

            foreach (var item in resources)
            {
                Console.WriteLine($"{item.Key} -> {item.Value}");
            }
        }
    }
}
