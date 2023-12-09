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
        public List<Card> card_deck = new List<Card>();//колода
        public byte[] S = { 3, 4, 5, 6 };//для вывода символов таблицы 
        public string[] T = { "6", "7", "8", "9", "10", "J", "Q", "K", "A" };
        public string[] Name_player = { "Player 1", "Player 2", "Player 3", "Player 4" };
        public List<Player> players = new List<Player>();//лист игроков
        List<Card> max_find = new List<Card>();//для поиска максимальной карты по приоритету
        public int Num_p { get; set; }//количество игроков
        public void SetPlayers()//усановить игроков
        {
            Console.WriteLine("Введите количество игроков от 2 до 4:");
            Num_p = Convert.ToInt32(Console.ReadLine());
            if (Num_p > 4) Num_p = 4;
            if (Num_p < 2) Num_p = 2;
            for (int i = 0; i < Num_p; i++)
            {
                players.Add(new Player { Name = Name_player[i] });
            }
        }
        public void SetCard_deck()//заполнение калоды карт
        {
            for (int i = 0; i < S.Length; i++)
            {
                for (int j = 0; j < T.Length; j++)
                {
                    card_deck.Add(new Card { Suit = S[i], Type_Card = T[j], Prioritet = j });
                }
            }
        }
        public void ShowCards()//вывести карты по игрокам
        {
            Console.SetCursorPosition(0, 2);
            for (int i = 0; i < players.Count; i++)
            {
                Console.WriteLine(players[i].Name);
                players[i].ShowCards();
                Console.WriteLine();
                Console.WriteLine();
            }
        }
        public void PrinrBlack()//зарисовочка
        {
            Console.SetCursorPosition(5, 15);
            Console.ForegroundColor= ConsoleColor.Black;
            Console.WriteLine("*********************************************");
            Console.ResetColor();
        }
        public void MixCards()//перемешать калоду
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
        public void Card_draw()//раздача карт
        {
            do
            {
                for (int i = 0; i < Num_p; i++)
                {
                    players[i].AddCards(card_deck[0]);
                    card_deck.RemoveAt(0);
                }
            } while (card_deck.Count != 0);
        }
        public void PutCard()//выкладка по одной карте каждого игрока
        {
            for (int i = 0; i < players.Count; i++)
            {
                if (players[i].CountQueue()>0)
                {
                    Console.SetCursorPosition(5 + (i * 10), 13);
                    Console.WriteLine(players[i].Name);
                    Console.SetCursorPosition(5 + (i * 10), 15);
                    max_find.Add(players[i].PutCard());
                }
                else { players.RemoveAt(i); }
            }
        }
        public void MaxFind()
        {      
            int max = max_find[0].Prioritet, ind=0;
            for (int i = 0; i < max_find.Count; i++)
            {
                if (max_find[i].Prioritet>max)
                {
                    max = max_find[i].Prioritet;
                    ind = i;
                }
            }
            for (int i = 0; i < max_find.Count; i++)
            {
                players[ind].AddCards(max_find[i]);
            }
            max_find.Clear();
        }
        public void NewGame()
        {
            ConsoleKey key;
            do
            {
                SetCard_deck();
                MixCards();
                SetPlayers();
                Card_draw();
                ShowCards();
                key = Console.ReadKey(true).Key;
                do
                {
                    Console.Clear();
                    ShowCards();
                    Console.Clear();
                    PutCard();
                    ShowCards();
                    MaxFind();
                    key = Console.ReadKey(true).Key;
                    PrinrBlack();
                    ShowCards();
                    key = Console.ReadKey(true).Key;
                } while (players.Count!=1);
                Console.WriteLine(players[0].Name + " is winner!!!");
                Console.WriteLine("Press any key fo continue");
                key = Console.ReadKey(true).Key;
                Console.Clear();
            } while (key != ConsoleKey.Escape);
        }
    }
}
