using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Goods
{
    abstract class Product
    {
        public string Name {  get; set; }
        public double Price {  get; set; }
        public int Quantity { get; set; }
        public Product(string name, double price, int quantity)
        {
            Name= name;
            Price= price;
            Quantity= quantity;
        }
        public abstract void AddPruduct(int quantity);
        public abstract void SalePruduct(int quantity);
        public abstract void Info();
        //public abstract string WriteFile();//??
    }
}
