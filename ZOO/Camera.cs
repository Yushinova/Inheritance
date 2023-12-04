using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
namespace ZOO
{
    public delegate void MyD();//делегаты на методы Animals
    class Camera
    {
        public void ShowAnimals(List<Animal> animals)
        {
            ConsoleKey key;
            do
            {
                int ind = choiseMenu(animals, 5, 5);
                animals[ind].Show();
                Console.SetCursorPosition(5, 10);
                animals[ind].Info();
                List<MyD> d = new List<MyD>();
                MyD var = null;
                d.Add(var = new MyD(animals[ind].Sleep));
                d.Add(var = new MyD(animals[ind].Walk));
                d.Add(var = new MyD(animals[ind].Speak));
                d.Add(var = new MyD(animals[ind].Eat));
                Random rand = new Random();
                int r = rand.Next(0, d.Count());
                Console.SetCursorPosition(5, 12);
                d[r]();
                key = Console.ReadKey(true).Key;
                Console.Clear();
            } while (key != ConsoleKey.Escape);
        }
        public void printMenu<T>(List<T> masMenu, int punct, int X, int Y)
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
        public int choiseMenu<T>(List<T> masMenu, int X, int Y)//выбор пунктов верх низ
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
