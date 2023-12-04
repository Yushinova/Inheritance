using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;

namespace ZOO
{
    class Lion : Animal
    {
        public override void Show()
        {
            char[,] lion =
                {
                { '*', '*', '-', '-', '*', '*', '*', '*', '*', '-', '-', '*', '*' },
                { '*', '-', '-', '-', '*', '*', '*', '*', '-', '-', '-', '-', '*' },
                { '*', '+', '*', '*', '*', '*', '*', '-', '-', '+', '/', '-', '*' },
                { '+', '+', '*', '+', '+', '+', '+', '-', '-', '-', '+', '+', '/' },
                { '+', '+', '+', '+', '+', '+', '+', '+', '-', '-', '+', '+', '+' },
                { '*', '+', '+', '+', '+', '+', '+', '+', '+', '+', '*', '*', '*' },
                { '*', '+', '+', '*', '*', '*', '+', '+', '*', '*', '*', '*', '*' }
            };
            Print(lion);
        }
        public override void Eat()
        {
            Console.WriteLine("Лев ест");
        }
        public override void Sleep()
        {
            Console.WriteLine("Лев спит");
        }
        public override void Speak()
        {
            Console.WriteLine("Лев рычит");
        }
        public override void Walk()
        {
            Console.WriteLine("Лев ходит по вольеру");
        }
        public override string ToString()
        {
            return "ЛЕВ    ";
        }
    }
}
