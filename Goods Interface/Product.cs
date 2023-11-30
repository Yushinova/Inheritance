using Goods_Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Goods
{
    abstract class Product: IProduct
    {
        public string Name {  get; set; }
        public double Price {  get; set; }
        public int Quantity { get; set; }
        public abstract bool CompareP(Product obj);
        public void AddPruduct(int quantity)
        {
            Quantity += quantity;
        }
        public void SalePruduct(int quantity)
        {
            if (quantity > Quantity) Console.WriteLine("Не хватает товара");
            else Quantity -= quantity;
        }
    }
}
