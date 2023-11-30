using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Goods_Interface;
namespace Goods
{
    abstract class Food : Product
    {
        public string Type { get; set; }
        public override string ToString()
        {
            return $"{Type}: {Name} Цена: {Price} руб. {Quantity} шт.";
        }
    }
}
