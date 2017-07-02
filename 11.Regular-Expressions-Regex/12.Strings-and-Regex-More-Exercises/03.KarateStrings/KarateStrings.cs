namespace _03.KarateStrings
{
    using System;
    using System.Text;

    public class KarateStrings
    {
        public static void Main()
        {
            string input = Console.ReadLine();

            int leftover = 0;

            int punchStrength = 0;
            var moves = input.Split('>');
            var sb = new StringBuilder();
            sb.Append($"{moves[0]}>");

            for (int i = 1; i < moves.Length; i++)
            {
                string currentMove = moves[i];

                punchStrength = int.Parse(currentMove[0].ToString()) + leftover;

                if (punchStrength <= currentMove.Length)
                {
                    currentMove = currentMove.Remove(0, punchStrength);
                    sb.Append($"{currentMove}>");

                }
                else
                {
                    leftover = punchStrength - currentMove.Length;
                    sb.Append(">");
                }
            }

            string output = sb.ToString();
            output = output.Remove(output.Length - 1, 1);
            Console.WriteLine(output);
        }
    }
}
