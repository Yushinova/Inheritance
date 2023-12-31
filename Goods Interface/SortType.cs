﻿using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Goods;
namespace Goods_Interface
{
    class SortType : IComparer<Product>
    {
        public int Compare(Product x, Product y)
        {
            if (x is Product && y is Product)
            {
                return String.Compare((x as Product).Type, (y as Product).Type);
            }
            throw new NotImplementedException();
        }
    }
}
