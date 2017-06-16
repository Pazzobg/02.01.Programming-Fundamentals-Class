namespace _06.ByteFlip
{
    using System;
    using System.Linq;

    public class ByteFlip
    {
        public static void Main()
        {
            var input = Console.ReadLine().Split(' ').Where(x => x.Length == 2).ToList();

            var resultString = input
                .Select(c => new string(c.Reverse().ToArray()))
                .Reverse()
                .ToList();

            string ascii = string.Empty;

            foreach (var item in resultString)
            {
                ascii += (char)(Convert.ToInt32(item, 16));
            }

            Console.WriteLine(ascii);
        }
    }
}
