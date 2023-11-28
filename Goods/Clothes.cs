using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Goods
{
    abstract class Clothes:Product
    {
        public int Size { get; set; }
        public Clothes(string name, double price, int quantity, int size) : base(name, price, quantity)
        {
            Size = size;
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
            return $"Размер: {Size} " + base.ToString();
        }
    }
}
