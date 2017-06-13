namespace _05.ShortWordsSorted
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class ShortWordsSorted
    {
        public static void Main()
        {
            string[] input = Console.ReadLine()
                .ToLower()
                .Split(". , : ; ( ) [ ] \" \' \\ / ! ? ".ToCharArray(), StringSplitOptions.RemoveEmptyEntries);

            var result = input
                .Distinct()
                .Where(x => x.Length < 5)
                .OrderBy(x => x);

            Console.WriteLine(string.Join(", ", result));
        }
    }
}
