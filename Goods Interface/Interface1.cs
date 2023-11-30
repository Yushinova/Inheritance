using Goods;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Goods_Interface
{
    interface IProduct
    {
        void AddPruduct(int quantity);
        void SalePruduct(int quantity);
        bool CompareP(Product obj);
    }
}
