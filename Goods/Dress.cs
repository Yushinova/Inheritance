using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Goods
{
    class Dress:Clothes
    {
        public Dress(string name, double price, int quantity, int size) : base(name, price, quantity, size) { }
        public override void Info()
        {
            Console.WriteLine($"{Name} Размер: {Size} Цена: {Price} руб. {Quantity} шт.");
        }
        public override string ToString() 
        {
            return base.ToString();
        }
    }
    
}
