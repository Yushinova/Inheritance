using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Goods
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<string> main_menu = new List<string>{ " Курица ", " Молоко ", " Хлеб   ", " Брюки  ", " Платье ", " Костюм " };
            List<string> choice_menu = new List<string>{ "Приход товара", "Продажа     " };
            List<Product> market = new List<Product>();
            string name, gender, season;
            double price, weight;
            int quantity, size;
            do
            {
                int ind = choiseMenu(choice_menu, 10, 5);
                if (ind == 0)
                {
                    Console.Clear();
                    ind = choiseMenu(main_menu, 10, 5);
                    switch (ind)
                    {
                        case 0:
                            {
                                Console.Write("Наименование: ");
                                name = Convert.ToString(Console.ReadLine());
                                Console.Write("Вес: ");
                                weight = Convert.ToDouble(Console.ReadLine());
                                Console.Write("Цена: ");
                                price = Convert.ToDouble(Console.ReadLine());
                                Console.Write("Количество: ");
                                quantity = Convert.ToInt32(Console.ReadLine());
                                Chicken chicken = new Chicken(name, price, quantity, "Курица", weight);
                                Proverka(market, chicken, quantity);
                                break;
                            }
                        case 1:
                            {
                                Console.Write("Наименование: ");
                                name = Convert.ToString(Console.ReadLine());
                                Console.Write("Цена: ");
                                price = Convert.ToDouble(Console.ReadLine());
                                Console.Write("Количество: ");
                                quantity = Convert.ToInt32(Console.ReadLine());
                                Milk milk = new Milk(name, price, quantity, "Молоко");
                                Proverka(market, milk, quantity);
                                break;
                            }
                        case 2:
                            {
                                Console.Write("Наименование: ");
                                name = Convert.ToString(Console.ReadLine());
                                Console.Write("Цена: ");
                                price = Convert.ToDouble(Console.ReadLine());
                                Console.Write("Количество: ");
                                quantity = Convert.ToInt32(Console.ReadLine());
                                Bread bread = new Bread(name, price, quantity, "Хлеб");
                                Proverka(market, bread, quantity);
                                break;
                            }
                        case 3:
                            {
                                Console.Write("Наименование: ");
                                name = Convert.ToString(Console.ReadLine());
                                Console.Write("Цена: ");
                                price = Convert.ToDouble(Console.ReadLine());
                                Console.Write("Количество: ");
                                quantity = Convert.ToInt32(Console.ReadLine());
                                Console.Write("Размер: ");
                                size = Convert.ToInt32(Console.ReadLine());
                                Console.Write("Гендер: ");
                                gender = Convert.ToString(Console.ReadLine());
                                Trousers trousers = new Trousers(name, price, quantity, size, gender);
                                Proverka(market, trousers, quantity);
                                break;
                            }
                        case 4:
                            {
                                Console.Write("Наименование: ");
                                name = Convert.ToString(Console.ReadLine());
                                Console.Write("Цена: ");
                                price = Convert.ToDouble(Console.ReadLine());
                                Console.Write("Количество: ");
                                quantity = Convert.ToInt32(Console.ReadLine());
                                Console.Write("Размер: ");
                                size = Convert.ToInt32(Console.ReadLine());
                                Dress dress = new Dress(name, price, quantity, size);
                                Proverka(market, dress, quantity);
                                break;
                            }
                        case 5:
                            {
                                Console.Write("Наименование: ");
                                name = Convert.ToString(Console.ReadLine());
                                Console.Write("Цена: ");
                                price = Convert.ToDouble(Console.ReadLine());
                                Console.Write("Количество: ");
                                quantity = Convert.ToInt32(Console.ReadLine());
                                Console.Write("Размер: ");
                                size = Convert.ToInt32(Console.ReadLine());
                                Console.Write("Гендер: ");
                                gender = Convert.ToString(Console.ReadLine());
                                Console.Write("Наименование: ");
                                season = Convert.ToString(Console.ReadLine());
                                Suit suit = new Suit(name, price, quantity, size, gender, season);
                                Proverka(market, suit, quantity);
                                break;
                            }
                    }

                }
                else
                {
                    ind = choiseMenu(market, 10, 5);
                    Console.WriteLine(ind);
                }
                foreach (var item in market)
                {
                    item.Info();
                }
            } while (true);

        }
        static void Proverka(List<Product> market, Product obj, int quantity)//если вносится товар который уже есть в магазине, то прибавляется только количество
        {
            if (market.Count == 0) market.Add(obj);
            else
            {
                foreach (var item in market)
                {
                    if (item.Equals(obj)) item.AddPruduct(quantity);
                    else market.Add(obj);
                }
            }
        }
        static void printMenu<T>(List<T> masMenu, int punct, int X, int Y)
        {
            for (int i = 0; i < masMenu.Count; i++)
            {
                if (i == punct)
                {
                    Console.BackgroundColor = ConsoleColor.Red;
                    Console.ForegroundColor = ConsoleColor.White;
                }
                else
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.BackgroundColor = ConsoleColor.White;
                }
                Console.SetCursorPosition(X, Y + i);
                 Console.Write(masMenu[i]);
            }
            Console.ResetColor();
        }
        static int choiseMenu<T>(List<T> masMenu, int X, int Y)//выбор пунктов верх низ
        {
            ConsoleKey key;
            int punctNumber = 0;
            do
            {
                printMenu(masMenu, punctNumber, X, Y);
                key = Console.ReadKey(true).Key;
                switch (key)
                {
                    case ConsoleKey.UpArrow:
                        if (punctNumber > 0)
                        {
                            punctNumber--;
                        }
                        break;

                    case ConsoleKey.DownArrow:
                        if (punctNumber < masMenu.Count - 1)
                        {
                            punctNumber++;
                        }
                        break;
                    case ConsoleKey.Enter:
                        if (punctNumber == masMenu.Count)
                        {
                            return -1;
                        }
                        return punctNumber;
                        break;
                }
            } while (key != ConsoleKey.Escape);
            return -1;
        }
    }

}
