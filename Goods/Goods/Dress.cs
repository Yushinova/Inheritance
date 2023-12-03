using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Goods
{
    class Dress:Clothes
    {
        public string Season { get; set; }
        public override string ToString() 
        {
            return base.ToString() + $" Сезон: {Season} ";
        }
    }
    
}
