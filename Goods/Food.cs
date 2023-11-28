using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Goods
{
    abstract class Food : Product
    {
        public string Type { get; set; }
        public Food(string name, double price, int quantity, string type) : base(name, price, quantity)
        {
            Type = type;
        }
        public override void AddPruduct(int quantity)
        {
            Quantity += quantity;
        }
        public override void SalePruduct(int quantity)
        {
            if (quantity > Quantity) Console.WriteLine("Не хватает товара");
            else Quantity -= quantity;
        }
        public override string ToString()
        {
            return $"{Type} " + base.ToString();
        }
    }
}
