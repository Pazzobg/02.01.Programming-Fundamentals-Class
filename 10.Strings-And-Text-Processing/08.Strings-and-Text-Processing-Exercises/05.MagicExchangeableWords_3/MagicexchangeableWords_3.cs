namespace _05.MagicExchangeableWords_3
{
    using System;
    using System.Linq;

    public class MagicExchangeableWords_3
    {
        public static void Main()
        {
            string[] words = Console.ReadLine().Split(' ');

            int firstStringLength = words[0].ToCharArray().Distinct().Count();
            int secondStringLenth = words[1].ToCharArray().Distinct().Count();
            // another option would be to fill in the chars into a HashSet<char>
            Console.WriteLine(firstStringLength != secondStringLenth ? "false" : "true");
        }
    }
}