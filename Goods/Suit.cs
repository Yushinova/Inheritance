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
        public Suit(string name, double price, int quantity, int size, string gender, string season) : base(name, price, quantity, size)
        {
            Gender = gender;
            Season = season;
        }
       
        public override void Info()
        {
            Console.WriteLine($"{Gender}: Костюм: {Name} Размер: {Size} Цена: {Price} руб. {Quantity} шт. Сезон: {Season}");
        }
        public override string ToString()
        {
            return $"{Gender} Сезон: {Season} " + base.ToString();
        }
    }
}
