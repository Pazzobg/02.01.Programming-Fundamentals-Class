namespace _04.VariableInHexFormat
{
    using System;

    public class VariableInHexFormat
    {
        public static void Main()
        {
            string hex = Console.ReadLine();
            Console.WriteLine(Convert.ToInt32(hex, 16));
        }
    }
}
