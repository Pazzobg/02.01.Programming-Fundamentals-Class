namespace _03.UnicodeCharacters
{
    using System;
    using System.Text;

    public class UnicodeCharacters
    {
        public static void Main()
        {
            var input = Console.ReadLine().ToCharArray();
            var sb = new StringBuilder();

            for (int i = 0; i < input.Length; i++)
            {
                var charAsDecimal = (int)input[i];

                var charAsHex = charAsDecimal.ToString("x");

                sb.Append($"\\u00{charAsHex}");
            }

            Console.WriteLine(sb.ToString());
        }
    }
}
