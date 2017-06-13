namespace _05.BooleanVariable
{
    using System;

    public class BooleanVariable
    {
        public static void Main()
        {
            string line = Console.ReadLine();
            bool converted = Convert.ToBoolean(line);

            if (converted)
            {
                Console.WriteLine("Yes");
            }
            else
            {
                Console.WriteLine("No");
            }
        }
    }
}
