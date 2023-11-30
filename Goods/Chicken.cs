using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Goods
{
    class Chicken : Food
    {
        public double Weight { get; set; }
        public override string ToString()
        {
            return base.ToString() + $" Вес: {Weight} кг.";
        }
    }
}
