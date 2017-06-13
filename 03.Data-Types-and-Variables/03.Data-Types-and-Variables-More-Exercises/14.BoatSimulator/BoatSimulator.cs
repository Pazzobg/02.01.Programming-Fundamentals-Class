namespace _14.BoatSimulator
{
    using System;

    public class BoatSimulator
    {
        public static void Main()
        {
            char player1 = char.Parse(Console.ReadLine());
            char player2 = char.Parse(Console.ReadLine());
            byte n = byte.Parse(Console.ReadLine());

            int positionPlayer1 = 0;
            int positionPlayer2 = 0;
            char playerWins = ' ';
            bool winner = false;

            for (byte i = 1; i <= n; i++)
            {
                string move = Console.ReadLine();

                if (move != "UPGRADE")
                {
                    if (i % 2 != 0)
                    {
                        positionPlayer1 += move.Length;
                        if (positionPlayer1 >= 50)
                        {
                            winner = true;
                            playerWins = player1;
                            break;
                        }
                    }
                    else
                    {
                        positionPlayer2 += move.Length; // V judge samo vtoriq test e sluchai,
                        if (positionPlayer2 >= 50)      // v koito player2 is a winner
                        {
                            winner = true;
                            playerWins = player2;
                            break;
                        }
                    }
                }
                else
                {
                    player1 = (char)(player1 + 3);
                    player2 = (char)(player2 + 3);
                }
            }

            if (winner)
            {
                Console.WriteLine(playerWins);
            }
            else
            {
                if (positionPlayer1 > positionPlayer2)
                {
                    Console.WriteLine(player1);
                }
                else
                {
                    Console.WriteLine(player2);
                }
            }
        }
    }
}
