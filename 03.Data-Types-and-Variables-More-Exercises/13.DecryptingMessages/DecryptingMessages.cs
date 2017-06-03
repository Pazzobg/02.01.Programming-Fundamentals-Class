namespace _13.DecryptingMessages
{
    using System;

    public class DecryptingMessages
    {
        public static void Main()
        {
            byte key = byte.Parse(Console.ReadLine());
            byte n = byte.Parse(Console.ReadLine());
            string result = string.Empty;

            for (byte i = 0; i < n; i++)
            {
                char input = char.Parse(Console.ReadLine());

                result += (char)(input + key);
            }

            Console.WriteLine(result);
        }
    }
}
