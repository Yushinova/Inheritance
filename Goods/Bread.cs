﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Goods
{
    class Bread:Food
    {
        public Bread(string name, double price, int quantity, string type) : base(name, price, quantity, type) { }
        public override void Info()
        {
            Console.WriteLine($"{Type}: {Name} Цена: {Price} руб. {Quantity} шт.");
        }
        public override string ToString()
        {
            return base.ToString();
        }
        //public override string WriteFile();//??
    }
}
