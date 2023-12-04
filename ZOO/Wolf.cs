﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZOO
{
    class Wolf: Animal
    {
        public override void Show()
        {
            char[,] wolf =
             {
                { '*', '*', '*', '*', '/', '*', '*', '/', '*', '*', '*', '*', '*','*','*','*','*','*','*','*' },
                { '*', '*', '*', '*', '/', '/', '*', '/', '*', '*', '*', '*', '*','*','*','*','*','*','*','*' },
                { '*', '*', '*', '/', '/', '/', '/', '/', '*', '*', '*', '*', '*','*','*','*','*','*','*','*' },
                { '.', '/', '/', '/', '.', '/', '/', '/', '*', '*', '*', '*', '*','*','*','*','*','*','*','*' },
                { '*', '/', '.', '/', '/', '/', '/', '/', '/', '*', '*', '*', '*','*','*','*','*','*','*','*' },
                { '*', '*', '*', '*', '*', '/', '/', '/', '/', '/', '/', '/', '/','/','/','/','*','*','*','*' },
                { '*', '*', '*', '*', '*', '*', '/', '/', '/', '/', '/', '/', '/','/','/','/','/','*','*','*' },
                { '*', '*', '*', '*', '*', '*', '/', '/', '/', '/', '/', '/', '/','/','/','/','/','/','/','/' },
                { '*', '*', '*', '*', '*', '*', '/', '/', '/', '/', '/', '/', '/','/','*','/','/','/','/','*' },
                { '*', '*', '*', '*', '*', '*', '/', '/', '*', '*', '*', '*', '/','/','/','*','*','*','*','*' },
                { '*', '*', '*', '*', '*', '*', '/', '/', '*', '*', '*', '*', '*','/','/','*','*','*','*','*' }

            };
            Print(wolf);
        }
        public override void Eat()
        {
            Console.WriteLine("Волчара грызет кость");
        }
        public override void Sleep()
        {
            Console.WriteLine("Волчара спит");
        }
        public override void Speak()
        {
            Console.WriteLine("Волчара воет У-У-У");
        }
        public override void Walk()
        {
            Console.WriteLine("Волчара беагет по клетке");
        }
        public override string ToString()
        {
            return "ВОЛЧАРА";
        }
    }
}