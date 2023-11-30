using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Goods
{
    abstract class Product
    {
        public string Name {  get; set; }
        public double Price {  get; set; }
        public int Quantity { get; set; }
        public void AddPruduct(int quantity)
        {
            Quantity += quantity;
        }
        public void SalePruduct(int quantity)
        {
            if (quantity > Quantity) Console.WriteLine("Не хватает товара");
            else Quantity -= quantity;
        }
        public bool CompareP(Product obj)//сравнение продукта по имени и цене для проверки повторяющихся продуктов
        {
            if (this.Name == obj.Name && this.Price == obj.Price) return true;
            else return false;
        }
        public override string ToString()
        {
            return $"{Name} Цена: {Price} руб. {Quantity} шт.";
        }
    }
}
