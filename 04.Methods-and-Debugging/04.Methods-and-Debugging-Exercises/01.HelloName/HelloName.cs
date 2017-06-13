namespace _01.HelloName
{
    using System;

    public class HelloName
    {
        public static void Main()
        {
            string name = Console.ReadLine();

            PrintName(name);
        }

        public static void PrintName(string name)
        {
            Console.WriteLine($"Hello, {name}!");
        }
    }
}
