using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Goods
{
    abstract class Clothes:Product
    {
        public string Type { get; set; }
        public int Size { get; set; }
        public override string ToString()
        {
            return $"{Type}: Размер: {Size} " + base.ToString();
        }
    }
}
