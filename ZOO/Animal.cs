using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace ZOO
{
    abstract class Animal : IAnimal
    {
        public string Type { get; set; }
        public string Gender { get; set; }
        public int Age { get; set; }
        public abstract void Show();//рисунок
        public abstract void Eat();
        public abstract void Sleep();
        public abstract void Speak();
        public abstract void Walk();
        public void Info()
        {
           Console.WriteLine("Info: " + Type + " Пол: " +  Gender + " Возраст: " +  Age + " лет");
        }
        public abstract override string ToString();
        public static void Print(char[,] mas)
        {

            for (int i = 0; i < mas.GetLength(0); i++)
            {
                Console.SetCursorPosition(5, 15 + i);
                for (global::System.Int32 j = 0; j < mas.GetLength(1); j++)
                {
                    if (mas[i, j] == '*')
                    {
                        Console.BackgroundColor = ConsoleColor.Black;
                        Console.ForegroundColor = ConsoleColor.Black;

                    }
                    else if (mas[i, j] == '+')
                    {
                        Console.BackgroundColor = ConsoleColor.Yellow;
                        Console.ForegroundColor = ConsoleColor.Yellow;
                    }
                    else if (mas[i, j] == '-')
                    {
                        Console.BackgroundColor = ConsoleColor.DarkYellow;
                        Console.ForegroundColor = ConsoleColor.DarkYellow;
                    }
                    else if (mas[i, j] == '.')
                    {
                        Console.BackgroundColor = ConsoleColor.Red;
                        Console.ForegroundColor = ConsoleColor.Red;
                    }
                    else
                    {
                        Console.BackgroundColor = ConsoleColor.Gray;
                        Console.ForegroundColor = ConsoleColor.Gray;
                    }
                    Console.Write(mas[i, j]);
                    Console.ResetColor();
                }
                Console.WriteLine();
            }
            Console.ResetColor();
        }
    }
}
