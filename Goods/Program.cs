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
                if (ind == 0)//поступление товара
                {
                    Console.Clear();
                    ind = choiseMenu(main_menu, 10, 5);
                    Console.SetCursorPosition(0, 13);
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
                                market.Add(chicken);
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
                                market.Add(milk);
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
                                market.Add(bread);
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
                                market.Add(trousers);
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
                                market.Add(dress);
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
                                market.Add(suit);
                                break;
                            }
                    }

                }
                else//продажа
                {
                    ind = choiseMenu(market, 10, 20);
                    Console.SetCursorPosition(50, 20);
                    Console.Write("Количество: ");
                    quantity = Convert.ToInt32(Console.ReadLine());
                    market[ind].SalePruduct(quantity);
                    Console.WriteLine(market[ind]);
                }
                foreach (var item in market)
                {
                    item.Info();
                }
            } while (true);

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
