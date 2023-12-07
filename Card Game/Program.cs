using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Card_Game
{
    internal class Program
    {
        static void Main(string[] args)
        {
           Game d = new Game();
            d.SetCard_deck();
            d.ShowCards();
            Console.WriteLine("After Mix");
            d.MixCards();
            d.ShowCards();
        }
    }
}
