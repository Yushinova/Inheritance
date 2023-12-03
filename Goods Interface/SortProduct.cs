using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace Goods_Interface
{
    class SortProduct : IComparer
    {
        public int Compare(object x, object y)
        {
            if (x is Food && y is Food)
            {
                return string.Compare((x as Food).Type, (y as Food).Type);
            }
            throw new NotImplementedException();
        }
    }
}
