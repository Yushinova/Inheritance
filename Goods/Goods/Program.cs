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
            List<string> main_menu = new List<string> { " Курица ", " Молоко ", " Хлеб   ", " Брюки  ", " Платье ", " Костюм " };
            List<string> choice_menu = new List<string> { "Приход товара", "Продажа      " };
            List<Product> market = new List<Product>();
            string name, gender, season;
            double price, weight, fat;
            int quantity, size;
            ConsoleKey key;
            do
            {
                int ind = choiseMenu(choice_menu, 1, 5);
                if (ind == 0)//поступление товара
                {
                    Console.Clear();
                    ind = choiseMenu(main_menu, 15, 5);
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
                                Chicken chicken = new Chicken { Name = name, Price = price, Quantity = quantity, Type = "Курица", Weight = weight };
                                Prov(market, chicken);
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
                                Console.Write("Жирность: ");
                                fat = Convert.ToDouble(Console.ReadLine());
                                Milk milk = new Milk { Name = name, Price = price, Quantity = quantity, Type = "Молоко", Fat = fat };
                                Prov(market, milk);
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
                                Bread bread = new Bread { Name = name, Price = price, Quantity = quantity, Type = "Хлеб" };
                                Prov(market, bread);
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
                                Trousers trousers = new Trousers { Name = name, Price = price, Quantity = quantity, Type = "Брюки", Size = size, Gender = gender };
                                Prov(market, trousers);
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
                                Console.Write("Сезон: ");
                                season = Convert.ToString(Console.ReadLine());
                                Dress dress = new Dress { Name = name, Price = price, Quantity = quantity, Type = "Платье", Size = size, Season = season };
                                Prov(market, dress);
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
                                Console.Write("Сезон: ");
                                season = Convert.ToString(Console.ReadLine());
                                Suit suit = new Suit { Name = name, Price = price, Quantity = quantity, Type = "Костюм", Size = size, Gender = gender, Season = season };
                                Prov(market, suit);
                                break;
                            }
                    }

                }
                else//продажа
                {
                    Console.Clear();
                    ind = choiseMenu(market, 1, 5);
                    Console.SetCursorPosition(45, 5);
                    Console.Write("Количество: ");
                    quantity = Convert.ToInt32(Console.ReadLine());
                    market[ind].SalePruduct(quantity);
                    //Console.WriteLine(market[ind]);
                }
                Console.SetCursorPosition(0, 20);
                foreach (var item in market)//смотрим изменения в магазине
                {
                    Console.WriteLine(item);
                }
                key = Console.ReadKey(true).Key;
            } while (key != ConsoleKey.Escape);
        }
        static void Prov(List<Product> prod, Product obj)//товары поступают через проверку, если такой товар есть, прибавляется количчество
        {
            if (prod.Count == 0) prod.Add(obj);
            else
            {
                for (global::System.Int32 i = 0; i < prod.Count; i++)
                {
                    if (prod[i].CompareP(obj))
                    {
                        prod[i].AddPruduct(obj.Quantity);
                        Console.WriteLine("Comp: " + prod[i].CompareP(obj));
                    }
                    else prod.Add(obj);
                    break;
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
