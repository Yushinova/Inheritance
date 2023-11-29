using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Goods
{
    class Trousers: Clothes
    {
        public string Gender { get; set; }
        public Trousers(string name, double price, int quantity, int size, string gender): base(name, price, quantity, size)
        { 
            Gender = gender;
        }
     
        public override void Info()
        {
            Console.WriteLine($"{Gender}: Брюки: {Name} Размер: {Size} Цена: {Price} руб. {Quantity} шт.");
        }
        public override string ToString()
        {
            return $"{Gender} " + base.ToString();
        }
    }
}
