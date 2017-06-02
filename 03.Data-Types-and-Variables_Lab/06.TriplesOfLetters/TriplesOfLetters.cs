namespace _06.TriplesOfLetters
{
    using System;

    public class TriplesOfLetters
    {
        public static void Main()
        {
            int n = int.Parse(Console.ReadLine());
            int end = 'a' + n;

            for (char i = 'a'; i < end; i++)
            {
                for (char j = 'a'; j < end; j++)
                {
                    for (char k = 'a'; k < end; k++)
                    {
                        Console.WriteLine($"{i}{j}{k} ");
                    }
                }
            }
        }
    }
}