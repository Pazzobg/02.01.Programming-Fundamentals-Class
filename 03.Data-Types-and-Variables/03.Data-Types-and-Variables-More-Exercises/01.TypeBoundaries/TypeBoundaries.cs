namespace _01.TypeBoundaries
{
    using System;

    public class TypeBoundaries
    {
        public static void Main()
        {
            string type = Console.ReadLine();

            switch (type)
            {
                case "sbyte":
                        Console.WriteLine(sbyte.MaxValue);
                        Console.WriteLine(sbyte.MinValue);
                    break;
                case "byte":
                        Console.WriteLine(byte.MaxValue);
                        Console.WriteLine(byte.MinValue);
                    break;
                case "int":
                    Console.WriteLine(int.MaxValue);
                    Console.WriteLine(int.MinValue);
                    break;
                case "uint":
                        Console.WriteLine(uint.MaxValue);
                        Console.WriteLine(uint.MinValue);
                    break;
                default:
                    Console.WriteLine(long.MaxValue);
                    Console.WriteLine(long.MinValue);
                    break;
            }
        }
    }
}
