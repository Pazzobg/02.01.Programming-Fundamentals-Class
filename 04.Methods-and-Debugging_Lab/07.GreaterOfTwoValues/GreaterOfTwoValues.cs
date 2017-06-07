namespace _07.GreaterOfTwoValues
{
    using System;

    public class GreaterOfTwoValues
    {
        static void Main()
        {
            string type = Console.ReadLine().ToLower().Trim();

            if (type == "int")
            {
                int a = int.Parse(Console.ReadLine());
                int b = int.Parse(Console.ReadLine());
                int result = GetMax(a, b);
                Console.WriteLine(result);
            }
            else if (type == "char")
            {
                char a = char.Parse(Console.ReadLine());
                char b = char.Parse(Console.ReadLine());
                char result = GetMax(a, b);
                Console.WriteLine(result);
            }
            else
            {
                string a = Console.ReadLine();
                string b = Console.ReadLine();
                string result = GetMax(a, b);
                Console.WriteLine(result);
            }
        }


        public static int GetMax(int a, int b)
        {
            int max = a > b ? a : b;
            return max;
        }

        public static char GetMax(char a, char b)
        {
            char max = a > b ? a : b;
            return max;
        }
        public static string GetMax(string a, string b)
        {
            string max = a.CompareTo(b) >= 0 ? a : b;
            return max;
        }
    }
}
