using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Goods
{
    class Chicken: Food
    {
        double Weight { get; set; }
        public Chicken(string name, double price, int quantity, string type, double weight) : base(name, price, quantity, type)
        {
            Weight = weight;
            Price *= Weight;//цена за кг переводим в цену за шт
        }
        public override void Info()
        {
            Console.WriteLine($"{Type}: Вес: {Weight} кг. {Name} Цена: {Price} руб. {Quantity} шт.");
        }
        public override string ToString()
        {
            return base.ToString()+$" Вес: {Weight} кг.";
        }
    }
}
