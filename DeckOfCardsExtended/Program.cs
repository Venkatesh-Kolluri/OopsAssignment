using System.Numerics;

namespace DeckOfCardsExtended
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] Suits = { "Clubs", "Diamonds", "Hearts", "Spades" };
            string[] Rank = { "2", "3", "4", "5", "6", "7", "8", "9", "10", "Jack", "Queen", "King", "Ace" };
            string[] Deck = new string[52];

            for (int i = 0; i < Rank.Length; i++)
            {
                for (int j = 0; j < Suits.Length; j++)
                {
                    Deck[Suits.Length * i + j] = Rank[i] + " of " + Suits[j];
                }
            }

            Random rand = new Random(); //shuffel
            for (int i = Deck.Length - 1; i >= 0; i--)
            {
                int j = rand.Next(i + 1);
                string temp = Deck[j];
                Deck[j] = Deck[i];
                Deck[i] = temp;
            }

            Player[] player = new Player[4];  //distribute
            for (int i = 0; i < 4; i++)
            {
                player[i] = new Player();
                for (int j = 0; j < 9; j++)
                {
                    player[i].AddCard(Deck[i * 9 + j]);
                }
                player[i].SortCards();
            }

            for (int i = 0; i < 4; i++) //players with cards
            {
                Console.WriteLine($"Player {i + 1} cards:");
                player[i].PrintCards();
                Console.WriteLine("==============================================================================");
            }
        }
    }
}