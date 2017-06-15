namespace _05.HandsOfCards
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class HandsOfCards
    {
        public static void Main()
        {
            var cardGame = new Dictionary<string, HashSet<string>>();

            string input = Console.ReadLine();

            while (input != "JOKER")
            {
                string[] currentPlayer = input.Split(':');
                string playerName = currentPlayer[0];
                string allCards = currentPlayer[1];
                string[] currentHand = allCards.Split(new[] { ' ', ',' }, StringSplitOptions.RemoveEmptyEntries);

                if (!cardGame.ContainsKey(playerName))
                {
                    cardGame[playerName] = new HashSet<string>();
                }

                foreach (var card in currentHand)
                {
                    cardGame[playerName].Add(card);
                }

                input = Console.ReadLine();
            }

            foreach (var player in cardGame)
            {
                string playerName = player.Key;
                int playerScore = CalculatePlayersScore(player.Value);

                Console.WriteLine($"{playerName}: {playerScore}");
            }
        }

        public static int CalculatePlayersScore(HashSet<string> cards)
        {
            int totalScore = 0;

            foreach (var card in cards)
            {
                int score = 0;
                int multiplyer = 0;
                char power = card[card.Length - 2];
                char suit = card[card.Length - 1];

                switch (power)
                {
                    case '2': score = 2; break;
                    case '3': score = 3; break;
                    case '4': score = 4; break;
                    case '5': score = 5; break;
                    case '6': score = 6; break;
                    case '7': score = 7; break;
                    case '8': score = 8; break;
                    case '9': score = 9; break;
                    case '0': score = 10; break;
                    case 'J': score = 11; break;
                    case 'Q': score = 12; break;
                    case 'K': score = 13; break;
                    case 'A': score = 14; break;
                }

                switch (suit)
                {
                    case 'S': multiplyer = 4; break;
                    case 'H': multiplyer = 3; break;
                    case 'D': multiplyer = 2; break;
                    case 'C': multiplyer = 1; break;
                }

                totalScore += score * multiplyer;
            }

            return totalScore;
        }
    }
}
