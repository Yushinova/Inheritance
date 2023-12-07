using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Card_Game
{
    internal class Player
    {
        public string Name { get; set; }
        Queue<Card> cards = new Queue<Card>();

    }
}
