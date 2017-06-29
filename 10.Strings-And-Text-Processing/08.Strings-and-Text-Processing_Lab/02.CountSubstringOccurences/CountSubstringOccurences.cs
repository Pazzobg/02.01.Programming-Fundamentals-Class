namespace _02.CountSubstringOccurences
{
    using System;

    public class CountSubstringOccurences
    {
        public static void Main()
        {
            string text = Console.ReadLine().ToLower();
            string match = Console.ReadLine().ToLower();

            int index = 0;
            int count = 0;

            while (true)
            {
                int found = text.IndexOf(match, index);

                if (found >= 0)
                {
                count++;
                index = found + 1;
                }
                else
                {
                    break;
                }
            }

            Console.WriteLine(count);
        }
    }
}
