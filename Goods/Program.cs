using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Goods
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Bread borodinski = new Bread("Бородинский хлеб",25.50,10,"Хлебобулочные изделия");
            borodinski.Info();
            borodinski.AddPruduct(10);
            borodinski.Info();
            Chicken yasnie_zori = new Chicken("Ясные зори", 120, 3, "Мясо", 1.5);
            yasnie_zori.Info();
        }
    }
}
