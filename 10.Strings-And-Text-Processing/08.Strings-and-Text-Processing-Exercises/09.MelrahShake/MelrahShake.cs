namespace _09.MelrahShake
{
    using System;

    public class MelrahShake
    {
        public static void Main()
        {
            string line = Console.ReadLine();
            string pattern = Console.ReadLine();

            while (true)
            {
                int firstOccuranceIndex = line.IndexOf(pattern);
                int lastOccuranceIndex = line.LastIndexOf(pattern);

                if (firstOccuranceIndex > -1
                    && lastOccuranceIndex > -1
                    && pattern.Length > 0
                    && firstOccuranceIndex != lastOccuranceIndex)
                {
                    line = line.Remove(line.IndexOf(pattern), pattern.Length);
                    line = line.Remove(line.LastIndexOf(pattern), pattern.Length);

                    Console.WriteLine("Shaked it.");

                    pattern = pattern.Remove(pattern.Length / 2, 1);
                }
                else
                {
                    Console.WriteLine("No shake.");
                    Console.WriteLine(line);
                    break;
                }
            }
        }
    }
}
