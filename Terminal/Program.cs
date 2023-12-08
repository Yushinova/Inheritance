using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Terminal
{
    internal class Program
    {
        static void ShowMassage(object sender, AccountEventArgs e)
        {
            Console.WriteLine($"Summ transaction: {e.Sum}");
            Console.WriteLine(e.MyMassage);
        }
        static void Main(string[] args)
        {
            Account ac = new Account(25000);
            ac.EventSum += ShowMassage;
            ac.EventGet += ShowMassage;
            ac.Put(1500);
            Console.WriteLine("**********************");
            ac.Get(20000);
            Console.WriteLine("**********************");
            ac.Get(15000);
        }
    }
}
