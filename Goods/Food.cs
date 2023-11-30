using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Goods
{
    abstract class Food : Product
    {
        public string Type { get; set; }
        public override string ToString()
        {
            return $"{Type}: " + base.ToString();
        }
    }
}
