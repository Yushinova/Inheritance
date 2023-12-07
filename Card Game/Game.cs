using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Card_Game
{
    internal class Game
    {
        Random random = new Random();
        public List<Card> card_deck = new List<Card>();
        public byte[] S = { 3, 4, 5, 6 };
        public string[] T = { "6", "7", "8", "9", "10", "J", "Q", "K", "A" };
        public string[] Name_player = { "Player 1", "Player 2", "Player 3", "Player 4" };
        public Player[] players = null;
        public int Num_p { get; set; }
        public void SetPlayers()
        {
            Console.WriteLine("Введите количество игроков от 2 до 4:");
            Num_p = Convert.ToInt32(Console.ReadLine());
            if (Num_p > 4) Num_p = 4;
            if (Num_p < 2) Num_p = 2;
            for (int i = 0; i < Num_p; i++)
            {
                players[i] = new Player { Name = Name_player[i] };
            }
        }
        public void SetCard_deck()
        {
            for (int i = 0; i < S.Length; i++)
            {
                for (global::System.Int32 j = 0; j < T.Length; j++)
                {
                    card_deck.Add(new Card { Suit = S[i], Type_Card = T[j], Prioritet = j });
                }
            }
        }
        public void ShowCards()
        {
            for (int i = 0; i < card_deck.Count; i++)
            {
                if (i > 0 && i % 9 == 0) Console.WriteLine();
                card_deck[i].PtintCard();
            }
            Console.WriteLine();
        }
        public void MixCards()
        {
            for (int i = 0; i < 4; i++)
            {
                for (int j = 0; j < card_deck.Count; j++)
                {
                    int ind = random.Next(card_deck.Count);
                    Card card = new Card();
                    card.CopyCard(card_deck[ind]);
                    card_deck.RemoveAt(ind);
                    card_deck.Add(card);
                }
            }

        }
    }
}
