using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Goods
{
    class Suit:Clothes
    {
        public string Gender { get; set; }
        public string Season { get; set; }
        public override bool CompareP(Product obj)//сравнение продукта по имени и цене для проверки повторяющихся продуктов
        {
            if (this.Name == obj.Name && this.Price == obj.Price && this.Gender==(obj as Suit).Gender && this.Size==(obj as Suit).Size) return true;
            else return false;
        }
        public override string ToString()
        {
            return base.ToString() + $" {Gender} Сезон: {Season} ";
        }
    }
}
