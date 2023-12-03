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
        public override string ToString()
        {
            return base.ToString() + $" {Gender} Сезон: {Season} ";
        }
    }
}
