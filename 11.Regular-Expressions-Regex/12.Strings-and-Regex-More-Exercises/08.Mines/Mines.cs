namespace _08.Mines
{
    using System;
    using System.Text;

    public class Mines
    {
        public static void Main()
        {
            string inputLine = Console.ReadLine();

            int startIndex = 0;
            int endIndex = 0;

            while ((startIndex = inputLine.IndexOf("<", startIndex)) != -1
                && (endIndex = inputLine.IndexOf(">", startIndex)) != -1)
            {
                string mineChars = inputLine.Substring(startIndex + 1, 2);
                int blastRadius = Math.Abs(mineChars[0] - mineChars[1]);

                int leftStart = Math.Max(0, startIndex - blastRadius);
                int rightEnd = Math.Min(inputLine.Length - 1, endIndex + blastRadius);

                var sb = new StringBuilder(inputLine);

                for (int i = leftStart; i <= rightEnd; i++)
                {
                    sb[i] = '_';
                }

                inputLine = sb.ToString();
            }

            Console.WriteLine(inputLine);
        }
    }
}
