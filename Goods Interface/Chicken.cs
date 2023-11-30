using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Goods_Interface;
namespace Goods
{
    class Chicken : Food
    {
        public double Weight { get; set; }

        public override bool CompareP(Product obj)//сравнение продукта по имени и цене для проверки повторяющихся продуктов
        {
            if (this.Name == obj.Name && this.Price == obj.Price && this.Weight==(obj as Chicken).Weight) return true;
            else return false;
        }
        public override string ToString()
        {
            return base.ToString() + $" Вес: {Weight} кг.";
        }
    }
}
