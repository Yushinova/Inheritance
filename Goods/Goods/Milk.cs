using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Goods
{
    class Milk: Food
    {
        public double Fat {  get; set; }
        public override string ToString()
        {
            return base.ToString() + $" {Fat} %";
        }
    }
}
