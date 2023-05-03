namespace DeckOfCards
{
    internal class DeckofCards
    {
        static void Main(string[] args)
        {
            string[] suits = { "Clubs", "Diamonds", "Hearts", "Spades" };
            string[] ranks = { "2", "3", "4", "5", "6", "7", "8", "9", "10", "Jack", "Queen", "King", "Ace" };
            int size = 52;
            string[] deck = new string[size];

            for (int i = 0; i < ranks.Length; i++)
            {
                for (int j = 0; j < suits.Length; j++)
                {
                    deck[suits.Length * i + j] = ranks[i] + " of " + suits[j];
                }
            }

            Random rand = new Random(); //shuffel
            for (int i = deck.Length - 1; i >= 0; i--)
            {
                int j = rand.Next(i + 1);
                string temp = deck[j];
                deck[j] = deck[i];
                deck[i] = temp;
            }

            string[,] players = new string[4, 9];  //   // distribute 
            for (int i = 0; i < 4; i++)
            {
                for (int j = 0; j < 9; j++)
                {
                    players[i, j] = deck[i * 9 + j];
                }
            }

            for (int i = 0; i < 4; i++)   //cards to player
            {
                Console.WriteLine($"Player {i + 1} cards:");
                for (int j = 0; j < 9; j++)
                {
                    Console.WriteLine(players[i, j]);
                }
                Console.WriteLine();
            }
        }
    }
}