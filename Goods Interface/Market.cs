using Goods;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Goods
{
    internal class Market : IEnumerable
    {
        Product[] market;
        public Market(List<Product> prod)
        {
            market = prod.ToArray();
        }
        IEnumerator IEnumerable.GetEnumerator()
        {
            return market.GetEnumerator();
        }
        public void Sort()
        {
            Array.Sort(market);
        }
        public void Sort(IComparer comparer)
        {
            Array.Sort(market, comparer);
        }
    }
}
